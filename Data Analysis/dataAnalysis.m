clear, close all, clc
pkg load signal

%Reading ServoGuide Files
  FrequencyResponseServoguide=csvread('ServoGuideFrequencyResponse.csv');
  %Data from servoguide file_in_loadpath
    SG_PHASE = FrequencyResponseServoguide(:,4);
    SG_GAIN = FrequencyResponseServoguide(:,3);
    SG_FREQUENCY = FrequencyResponseServoguide(:,2);

%Reading Own Software File
  TimeResponseOwnsoftware=csvread('SoftwareTimeResponse.csv');   
  %Data from own software file
    OS_TCMD=TimeResponseOwnsoftware([2023:47677],1);
    OS_FRTCM=TimeResponseOwnsoftware([2023:47677],2);
    OS_FREQUENCY=TimeResponseOwnsoftware([2023:47677],3);
    OS_TIME=0:0.25:(length(OS_FREQUENCY)-1)*0.25;

if false
  figure
  subplot(3,3,1)
  plot(OS_TIME, OS_FRTCM, 'b')
  title('Input Signal (FRTCM)')
  subplot(3,3,2)
  plot(OS_TIME, OS_TCMD, 'k')
  title('Output Signal (TCMD)')
  grid
  
  Fsam = 1000/0.25; #4000 Hz
  Fnyq = Fsam/2;
  Fc = 500; %Cutting Frequency
  [b, a] = butter(10, Fc/Fnyq);
  t = OS_TIME;
  input = OS_TCMD;
  output = filter(b,a,input);
  subplot(3,3,3)
  plot(t, output,'r')
  title('Filtered ouput (TCMD)')
  grid
  OS_TCMD_BUTTER = output;
  
  n = length(OS_TIME);
  uT = abs(fft(OS_FRTCM)/n);
  u = 2*uT(1:n/2+1);
  u(1:end-1) = u(1:end-1);
  f = Fsam * (1:(n/2)+1)/n;
  subplot(3,3,4)
  semilogx(f,u,'b')
  title('Input signal frequency spectrum')
  grid 
  u_OS_FRTCM = u;
  
  uT = fft(OS_TCMD)/n;
  u = 2*uT(1:n/2+1);
  u(1:end-1) = u(1:end-1);
  f = Fsam * (1:(n/2)+1)/n;
  subplot(3,3,5)
  semilogx(f,abs(u),'k')
  title('Output signal frequency spectrum')
  grid
  u_OS_TCMD = u;
  
  uT = fft(OS_TCMD_BUTTER)/n;
  u = 2*uT(1:n/2+1);
  u(1:end-1) = u(1:end-1);
  f = Fsam * (1:(n/2)+1)/n;
  subplot(3,3,6)
  semilogx(f,abs(u),'r')
  title('Filtered output signal frequency spectrum')
  grid
  u_OS_TCMD_BUTTER = u;
  
  H_ORIGINAL = abs(u_OS_TCMD./u_OS_FRTCM);
  f = Fsam * (1:(n/2)+1)/n;
  MagData = 20*log10(H_ORIGINAL);
  subplot(3,3,8)
  semilogx(f,MagData,'k')
  title('Bode Diagrama Original Data (Magnitude)')
  grid
  
  H_FILTERED = u_OS_TCMD_BUTTER./u_OS_FRTCM;
  f = Fsam * (1:(n/2)+1)/n;
  MagData = 20*log10(abs(H_FILTERED));
  PhaseData = angle(H_FILTERED)*180/pi;
  subplot(3,3,9)
  semilogx(f,MagData,'r')
  title('Bode Diagrama Filtered Data (Magnitude)')
  grid
end

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
Fc = 500; %Cutting Frequency
[b, a] = butter(10, Fc/Fnyq);
t = OS_TIME;
input = OS_TCMD;
output = filter(b,a,input);
OS_TCMD_BUTTER = output;

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
aux_OS_TCMD_BUTTER = [0];
MAXS = [];
for i=1:length(OS_FREQUENCY)
  if OS_FREQUENCY(i) == FREQUENCIES(j)
    aux_OS_TCMD = [aux_OS_TCMD; OS_TCMD(i)];
    aux_OS_FRTCM = [aux_OS_FRTCM; OS_FRTCM(i)];
    aux_OS_TCMD_BUTTER = [aux_OS_TCMD_BUTTER; OS_TCMD_BUTTER(i)];
    else
      n = length(aux_OS_FRTCM);
      f = Fsam * (1:(n/2)+1)/n;
      
      uT = abs(fft(aux_OS_FRTCM)/n);
      u = 2*uT(1:n/2+1);
      u(1:end-1) = u(1:end-1);
      max_OS_FRTCM = max(u);
      
      uT = fft(aux_OS_TCMD)/n;
      u = 2*uT(1:n/2+1);
      u(1:end-1) = u(1:end-1);
      max_OS_TCMD = max(u);
      
      uT = fft(aux_OS_TCMD_BUTTER)/n;
      u = 2*uT(1:n/2+1);
      u(1:end-1) = u(1:end-1);
      max_OS_TCMD_BUTTER = max(u);

    MAXS = [MAXS;FREQUENCIES(j), max_OS_FRTCM, max_OS_TCMD, max_OS_TCMD_BUTTER];
    aux_OS_TCMD = [];
    aux_OS_FRTCM = [];
    aux_OS_TCMD_BUTTER = [];
    aux_OS_TCMD = [aux_OS_TCMD; OS_TCMD(i)];
    aux_OS_FRTCM = [aux_OS_FRTCM; OS_FRTCM(i)];
    aux_OS_TCMD_BUTTER = [aux_OS_TCMD_BUTTER; OS_TCMD_BUTTER(i)];
    j=j+1;
  end
end
MAXS = [MAXS;FREQUENCIES(j), max_OS_FRTCM, max_OS_TCMD, max_OS_TCMD_BUTTER];

% Plotting Bode Diagram
  %Plotting results after handling data
  H = MAXS(:,3)./MAXS(:,2);
  f = MAXS(:,1);
  MagData = 20*log10(abs(H));
  PhaseData = angle(H)*180/pi-100;
  figure
  subplot(2,2,1)
  semilogx(f,MagData)
  title('Magnitude')
  grid
  subplot(2,2,3)
  semilogx(f,PhaseData)
  title('Phase')
  grid

  %Plotting results from servoguide
  subplot(2,2,2)
  semilogx(SG_FREQUENCY,SG_GAIN,'r')
  title('Magnitude (Servoguide)')
  grid
  subplot(2,2,4)
  semilogx(SG_FREQUENCY,SG_PHASE,'r')
  title('Phase (Servoguide)')
  grid
  clear all