clear, close all, clc

%Reading data from servoguide
if true
  cd 'Servoguide'
  FrequencyResponseServoguide_1=csvread('Frequency_Response_Axis-1_1_-_1000Hz-1.csv');
    SG_FREQ_1 = FrequencyResponseServoguide_1([5:end],2);
    SG_PHAS_1 = FrequencyResponseServoguide_1([5:end],4);
    SG_GAIN_1 = FrequencyResponseServoguide_1([5:end],3);
  FrequencyResponseServoguide_100=csvread('Frequency_Response_Axis-1_1_-_1000Hz-100.csv');
    SG_FREQ_100 = FrequencyResponseServoguide_100([5:end],2);
    SG_PHAS_100 = FrequencyResponseServoguide_100([5:end],4);
    SG_GAIN_100 = FrequencyResponseServoguide_100([5:end],3);
  FrequencyResponseServoguide_500=csvread('Frequency_Response_Axis-1_1_-_1000Hz-500.csv');
    SG_FREQ_500 = FrequencyResponseServoguide_500([5:end],2);
    SG_PHAS_500 = FrequencyResponseServoguide_500([5:end],4);
    SG_GAIN_500 = FrequencyResponseServoguide_500([5:end],3);
  FrequencyResponseServoguide_1000=csvread('Frequency_Response_Axis-1_1_-_1000Hz-1000.csv');
    SG_FREQ_1000 = FrequencyResponseServoguide_1000([5:end],2);
    SG_PHAS_1000 = FrequencyResponseServoguide_1000([5:end],4);
    SG_GAIN_1000 = FrequencyResponseServoguide_1000([5:end],3);
  FrequencyResponseServoguide_2000=csvread('Frequency_Response_Axis-1_1_-_1000Hz-2000.csv');
    SG_FREQ_2000 = FrequencyResponseServoguide_2000([5:end],2);
    SG_PHAS_2000 = FrequencyResponseServoguide_2000([5:end],4);
    SG_GAIN_2000 = FrequencyResponseServoguide_2000([5:end],3);
  cd ..
  
  PR = 5;
  PC = 2;
  subplot(PR,PC,1)
  semilogx(SG_FREQ_1, SG_GAIN_1)
  title('Magnitude')
  grid
  subplot(PR,PC,2)
  semilogx(SG_FREQ_1, SG_PHAS_1)
  title('Phase')
  grid
  
  subplot(PR,PC,3)
  semilogx(SG_FREQ_100, SG_GAIN_100)
  title('Magnitude')
  grid
  subplot(PR,PC,4)
  semilogx(SG_FREQ_100, SG_PHAS_100)
  title('Phase')
  grid
  
  subplot(PR,PC,5)
  semilogx(SG_FREQ_500, SG_GAIN_500)
  title('Magnitude')
  grid
  subplot(PR,PC,6)
  semilogx(SG_FREQ_500, SG_PHAS_500)
  title('Phase')
  grid
  
  subplot(PR,PC,7)
  semilogx(SG_FREQ_1000, SG_GAIN_1000)
  title('Magnitude')
  grid
  subplot(PR,PC,8)
  semilogx(SG_FREQ_1000, SG_PHAS_1000)
  title('Phase')
  grid
  
  subplot(PR,PC,9)
  semilogx(SG_FREQ_2000, SG_GAIN_2000)
  title('Magnitude')
  grid
  subplot(PR,PC,10)
  semilogx(SG_FREQ_2000, SG_PHAS_2000)
  title('Phase')
  grid
end

%Reading data from servoguide (time domain)
if true
  cd 'Servoguide'
  [HM_GAIN_1, HM_PHASE_1, HM_FREQ_1] = BodeData('Time_Response_Axis-1_1_-_1000Hz_1.csv');
  [HM_GAIN_2, HM_PHASE_2, HM_FREQ_2] = BodeData('Time_Response_Axis-1_1_-_1000Hz_100.csv');
  [HM_GAIN_3, HM_PHASE_3, HM_FREQ_3] = BodeData('Time_Response_Axis-1_1_-_1000Hz_500.csv');
  [HM_GAIN_4, HM_PHASE_4, HM_FREQ_4] = BodeData('Time_Response_Axis-1_1_-_1000Hz_1000.csv');
  [HM_GAIN_5, HM_PHASE_5, HM_FREQ_5] = BodeData('Time_Response_Axis-1_1_-_1000Hz_2000.csv');  
  cd ..
  
  PR = 5;
  PC = 2;
  figure
  subplot(PR,PC,1)
  semilogx(SG_FREQ_1, SG_GAIN_1)
  title('Magnitude')
  grid
  subplot(PR,PC,2)
  semilogx(SG_FREQ_1, SG_PHAS_1)
  title('Phase')
  grid
  
  subplot(PR,PC,3)
  semilogx(SG_FREQ_100, SG_GAIN_100)
  title('Magnitude')
  grid
  subplot(PR,PC,4)
  semilogx(SG_FREQ_100, SG_PHAS_100)
  title('Phase')
  grid
  
  subplot(PR,PC,5)
  semilogx(SG_FREQ_500, SG_GAIN_500)
  title('Magnitude')
  grid
  subplot(PR,PC,6)
  semilogx(SG_FREQ_500, SG_PHAS_500)
  title('Phase')
  grid
  
  subplot(PR,PC,7)
  semilogx(SG_FREQ_1000, SG_GAIN_1000)
  title('Magnitude')
  grid
  subplot(PR,PC,8)
  semilogx(SG_FREQ_1000, SG_PHAS_1000)
  title('Phase')
  grid
  
  subplot(PR,PC,9)
  semilogx(SG_FREQ_2000, SG_GAIN_2000)
  title('Magnitude')
  grid
  subplot(PR,PC,10)
  semilogx(SG_FREQ_2000, SG_PHAS_2000)
  title('Phase')
  grid
end

%Reading data from homemade 
if true
  cd 'Homemade Software'
  FrequencyResponseServoguide_1=csvread('Freq_FrqRes_1,3A_60867D.csv');
    SG_FREQ_1 = FrequencyResponseServoguide_1(1,:);
    SG_PHAS_1 = FrequencyResponseServoguide_1(3,:);
    SG_GAIN_1 = FrequencyResponseServoguide_1(2,:);
  FrequencyResponseServoguide_100=csvread('Freq_FrqRes_1,3A_76087D.csv');
    SG_FREQ_2 = FrequencyResponseServoguide_100(1,:);
    SG_PHAS_2 = FrequencyResponseServoguide_100(3,:);
    SG_GAIN_2 = FrequencyResponseServoguide_100(2,:);
  FrequencyResponseServoguide_500=csvread('Freq_FrqRes_1.3A_91304D.csv');
    SG_FREQ_3 = FrequencyResponseServoguide_500(1,:);
    SG_PHAS_3 = FrequencyResponseServoguide_500(3,:);
    SG_GAIN_3 = FrequencyResponseServoguide_500(2,:);
  FrequencyResponseServoguide_1000=csvread('Freq_FrqRes_7A_45658D.csv');
    SG_FREQ_4 = FrequencyResponseServoguide_1000(1,:);
    SG_PHAS_4 = FrequencyResponseServoguide_1000(3,:);
    SG_GAIN_4 = FrequencyResponseServoguide_1000(2,:);
  FrequencyResponseServoguide_2000=csvread('Freq_FrqRes_7A_78048D.csv');
    SG_FREQ_5 = FrequencyResponseServoguide_2000(1,:);
    SG_PHAS_5 = FrequencyResponseServoguide_2000(3,:);
    SG_GAIN_5 = FrequencyResponseServoguide_2000(2,:);
  FrequencyResponseServoguide_2000=csvread('Freq_FrqRes_12A_45653D.csv');
    SG_FREQ_6 = FrequencyResponseServoguide_2000(1,:);
    SG_PHAS_6 = FrequencyResponseServoguide_2000(3,:);
    SG_GAIN_6 = FrequencyResponseServoguide_2000(2,:);
  cd ..
  
  FR = 6;
  FC = 2;
  figure
  subplot(FR,FC,1)
  semilogx(SG_FREQ_4, SG_GAIN_4)
  title('Magnitude')
  grid
  subplot(FR,FC,2)
  semilogx(SG_FREQ_4, SG_PHAS_4)
  title('Phase')
  grid
  
  subplot(FR,FC,3)
  semilogx(SG_FREQ_5, SG_GAIN_5)
  title('Magnitude')
  grid
  subplot(FR,FC,4)
  semilogx(SG_FREQ_5, SG_PHAS_5)
  title('Phase')
  grid
  
  subplot(FR,FC,5)
  semilogx(SG_FREQ_3, SG_GAIN_3)
  title('Magnitude')
  grid
  subplot(FR,FC,6)
  semilogx(SG_FREQ_3, SG_PHAS_3)
  title('Phase')
  grid
  
  subplot(FR,FC,7)
  semilogx(SG_FREQ_1, SG_GAIN_1)
  title('Magnitude')
  grid
  subplot(FR,FC,8)
  semilogx(SG_FREQ_1, SG_PHAS_1)
  title('Phase')
  grid
  
  subplot(FR,FC,9)
  semilogx(SG_FREQ_6, SG_GAIN_6)
  title('Magnitude')
  grid
  subplot(FR,FC,10)
  semilogx(SG_FREQ_6, SG_PHAS_6)
  title('Phase')
  grid
  
  subplot(FR,FC,11)
  semilogx(SG_FREQ_2, SG_GAIN_2)
  title('Magnitude')
  grid
  subplot(FR,FC,12)
  semilogx(SG_FREQ_2, SG_PHAS_2)
  title('Phase')
  grid
end

%Reading data from homemade software (time domain)
if true
  cd 'Homemade Software'
  [HM_GAIN_1, HM_PHASE_1, HM_FREQ_1] = BodeData('Time_FrqRes_1,3A_60867D.csv');
  [HM_GAIN_2, HM_PHASE_2, HM_FREQ_2] = BodeData('Time_FrqRes_1,3A_76087D.csv');
  [HM_GAIN_3, HM_PHASE_3, HM_FREQ_3] = BodeData('Time_FrqRes_1.3A_91304D.csv');
  [HM_GAIN_4, HM_PHASE_4, HM_FREQ_4] = BodeData('Time_FrqRes_7A_45658D.csv');
  [HM_GAIN_5, HM_PHASE_5, HM_FREQ_5] = BodeData('Time_FrqRes_7A_78048D.csv');  
  [HM_GAIN_6, HM_PHASE_6, HM_FREQ_6] = BodeData('Time_FrqRes_12A_45653D.csv'); 
  cd ..
  
  FR = 6;
  FC = 2;
  figure
  subplot(FR,FC,1)
  semilogx(HM_FREQ_1, HM_GAIN_1)
  title('Magnitude')
  grid
  subplot(FR,FC,2)
  semilogx(HM_FREQ_1, HM_PHASE_1)
  title('Phase')
  grid
  
  subplot(FR,FC,3)
  semilogx(HM_FREQ_2, HM_GAIN_2)
  title('Magnitude')
  grid
  subplot(FR,FC,4)
  semilogx(HM_FREQ_2, HM_PHASE_2)
  title('Phase')
  grid
  
  subplot(FR,FC,5)
  semilogx(HM_FREQ_3, HM_GAIN_3)
  title('Magnitude')
  grid
  subplot(FR,FC,6)
  semilogx(HM_FREQ_3, HM_PHASE_3)
  title('Phase')
  grid
  
  subplot(FR,FC,7)
  semilogx(HM_FREQ_4, HM_GAIN_4)
  title('Magnitude')
  grid
  subplot(FR,FC,8)
  semilogx(HM_FREQ_4, HM_PHASE_4)
  title('Phase')
  grid
  
  subplot(FR,FC,9)
  semilogx(HM_FREQ_5, HM_GAIN_5)
  title('Magnitude')
  grid
  subplot(FR,FC,10)
  semilogx(HM_FREQ_5, HM_PHASE_5)
  title('Phase')
  grid
  
  subplot(FR,FC,11)
  semilogx(HM_FREQ_6, HM_GAIN_6)
  title('Magnitude')
  grid
  subplot(FR,FC,12)
  semilogx(HM_FREQ_6, HM_PHASE_6)
  title('Phase')
  grid
end