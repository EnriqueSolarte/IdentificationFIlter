clear, close all, clc
pkg load signal

%Reading ServoGuide Files
FrequencyResponseServoguide=csvread('ServoGuideFrequencyResponse1.csv');
%Data from servoguide file_in_loadpath
  SG_PHASE = FrequencyResponseServoguide([5:end],4);
  SG_GAIN = FrequencyResponseServoguide([5:end],3);
  SG_FREQUENCY = FrequencyResponseServoguide([5:end],2);

%Reading Own Software File
TimeResponseOwnsoftware=csvread('SoftwareTimeResponse.csv');   
%Data from own software file
  OS_TCMD=TimeResponseOwnsoftware([2023:47677],1);
  OS_FRTCM=TimeResponseOwnsoftware([2023:47677],2);
  OS_FREQUENCY=TimeResponseOwnsoftware([2023:47677],3);
  OS_TIME=0:0.25:(length(OS_FREQUENCY)-1)*0.25;

% Extracting frequencies range
j=1;
for i=1:length(OS_FREQUENCY)-1
  if OS_FREQUENCY(i) != OS_FREQUENCY(i+1) || i == length(OS_FREQUENCY)-1
    FREQUENCIES(j)=OS_FREQUENCY(i);
    j=j+1;
  end
end

% Define variables
Fsam = 1000/0.25; #4000 Hz
Fnyq = Fsam/2;

% Plotting input and output
if false
  figure
  subplot(3,3,1)
  plot(OS_TIME, OS_FRTCM, 'b')
  title('Input Signal (FRTCM)')
  subplot(3,3,2)
  plot(OS_TIME, OS_TCMD, 'k')
  title('Output Signal (TCMD)')
  grid
  subplot(3,3,3)
  plot(t, output,'r')
  title('Filtered ouput (TCMD)')
  grid
end 

% Extracting maximum values
j=1;
aux_OS_TCMD = [0];
aux_OS_FRTCM = [0];
MAXS = [];
for i=1:length(OS_FREQUENCY)
  if OS_FREQUENCY(i) == FREQUENCIES(j)
    aux_OS_TCMD = [aux_OS_TCMD; OS_TCMD(i)];
    aux_OS_FRTCM = [aux_OS_FRTCM; OS_FRTCM(i)];
  else
    n = length(aux_OS_FRTCM);
    
    uT = fft(aux_OS_FRTCM);
    u = 2/n*uT(1:n/2);
    max_OS_FRTCM = max(u);

    uT = fft(aux_OS_TCMD);
    u = 2/n*uT(1:n/2);
    max_OS_TCMD = max(u);

% Plotting frequency spectrum per each batch
%    f = Fsam * (1:(n/2)+1)/n;    
%    if mod(FREQUENCIES(j),100) == 0
%      figure
%      semilogx(f,u)
%      grid
%    end

    MAXS = [MAXS;FREQUENCIES(j), max_OS_FRTCM, max_OS_TCMD];
    aux_OS_TCMD = [];
    aux_OS_FRTCM = [];
    aux_OS_TCMD = [aux_OS_TCMD; OS_TCMD(i)];
    aux_OS_FRTCM = [aux_OS_FRTCM; OS_FRTCM(i)];
    j=j+1;
  end
end

MAXS = [MAXS;FREQUENCIES(j), max_OS_FRTCM, max_OS_TCMD];

% Preparing Bode Diagram
H = MAXS(:,3)./MAXS(:,2);
f = MAXS(:,1);
MagData = 20*log10(abs(H));
PhaseData = angle(H)*180/pi;

% Extract frequencies to be filtered
j=1;
for i=1:208
  if f(i)>=350
    auxf(j)=f(i);
    auxPD(j)=PhaseData(i);
    if j==1
      index = i;
    end
    j=j+1;
  end
end

%Kalman Filter
Xest=[PhaseData(index-1)];
Pest=[1];
Z=auxPD;
R = 1;
Q = 0.1;

for i = 1:length(auxPD)
  % Prediction
  Xestm(i) = Xest(i);
  Pestm(i) = Pest(i)+Q;
  % Correction
  K(i) = Pestm(i)/(Pestm(i) + R);
  Xest(i+1)=Xestm(i) + K(i)*(Z(i)-Xestm(i));
  Pest(i+1)=(1-K(i))*Pestm(i);
end

PhaseDataKalman = PhaseData;
PhaseDataKalman(index:length(PhaseDataKalman)) = Xest(2:end);

figure
subplot(2,3,1)
semilogx(f,MagData)
title('Magnitude')
grid
subplot(2,3,4)
semilogx(f,PhaseData)
title('Phase')
grid

%Plotting results from servoguide
subplot(2,3,2)
semilogx(SG_FREQUENCY,SG_GAIN,'r')
title('Magnitude (Servoguide)')
grid
subplot(2,3,5)
semilogx(SG_FREQUENCY,SG_PHASE,'r')
title('Phase (Servoguide)')
grid

subplot(2,3,3)
semilogx(f,MagData)
title('Magnitude')
hold on 
semilogx(SG_FREQUENCY,SG_GAIN,'r')
grid
subplot(2,3,6)
semilogx(f,PhaseData)
title('Phase')
hold on
semilogx(SG_FREQUENCY,SG_PHASE,'r')
grid