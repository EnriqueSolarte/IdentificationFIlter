clear, close all, clc

%Reading ServoGuide Files
  FrequencyResponseServoguide=csvread('ServoGuideFrequencyResponse.csv');
      SG_FREQUENCY=FrequencyResponseServoguide(:,2);
      SG_GAIN=FrequencyResponseServoguide(:,3);
      SG_PHASE=FrequencyResponseServoguide(:,4);
  
%Reading Own Software File
  TimeResponseOwnsoftware=csvread('SoftwareTimeResponse.csv');   
  %Data from own softare file
    OS_TCMD=TimeResponseOwnsoftware([2023:47678],1);
    OS_FRTCM=TimeResponseOwnsoftware([2023:47678],2);
    OS_FREQUENCY=TimeResponseOwnsoftware([2023:47678],3);
    OS_TIME=0:0.25:(length(OS_FREQUENCY)-1)*0.25;
    %

%Extracting frequencies range
  j=1;
  for i=1:length(OS_FREQUENCY)-1
    if OS_FREQUENCY(i) != OS_FREQUENCY(i+1) || i == length(OS_FREQUENCY)-1
      FREQUENCIES(j)=OS_FREQUENCY(i);
      j=j+1;
      end
    end
    
%Extracting average, sumatory and frequency population
  j=1;
  k=1;
  aux=0;
  aux1=0;
  for i=1:length(OS_FREQUENCY)
    if OS_FREQUENCY(i) == FREQUENCIES(j)
      aux = aux+OS_TCMD(i);
      aux1 = aux1+OS_FRTCM(i);
      k=k+1;
      else
      SUMATORY(j) = aux;
      AVERAGE(j) = aux/k;
      AVERAGE1(j)= aux1/k;
      aux=0;
      aux = aux+OS_TCMD(i);
      aux1=0;
      aux1 = aux1+OS_FRTCM(i);
      FREQUENCY_POPULATION(j)=k;
      k=1;
      j=j+1;
      end
    end
    
  if j==length(FREQUENCIES)
    AVERAGE(j) = aux/k;
    AVERAGE1(j) = aux1/k;
    k=1;
    j=j+1;
    aux=0;
    end
    
  csvwrite('Data.csv',[FREQUENCIES;FREQUENCY_POPULATION;SUMATORY;AVERAGE;AVERAGE1]');
  figure
  plot(FREQUENCIES, AVERAGE1)
  hold on
  plot(FREQUENCIES, AVERAGE,'r');
    
if true
  %Processing Time Domain Data
%    n = length(OS_FREQUENCY); %Number of samples
    n = length(FREQUENCIES);
    u = fft(AVERAGE1,n);
%    u = fft(OS_FRTCM,n);
    y = fft(AVERAGE,n);
%    y = fft(OS_TCMD,n);
    
    H = (u.*y./u.^2);
    MagData = 20*log10(H.*conj(H));
  %  MagData = U.*conj(U)/n;
    PhaseData = angle(H)*180/pi;
    FreqData = FREQUENCIES;
%    FreqData = OS_FREQUENCY;
%    FreqData = 1:999/n:1000;
%    FreqData(length(FreqData)) = [];
    figure
    subplot(2,1,1)
    semilogx(FreqData, MagData);
    grid
    subplot(2,1,2)
    semilogx(FreqData, PhaseData);
    grid
    
    M=[SG_FREQUENCY, SG_GAIN, SG_PHASE];
  
  %Plotting Data
    figure
    plottingData(FrequencyResponseServoguide,TimeResponseOwnsoftware,M);
    endif