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
  
  subplot(5,2,1)
  semilogx(SG_FREQ_1, SG_GAIN_1)
  title('Magnitude')
  grid
  subplot(5,2,2)
  semilogx(SG_FREQ_1, SG_PHAS_1)
  title('Phase')
  grid
  
  subplot(5,2,3)
  semilogx(SG_FREQ_100, SG_GAIN_100)
  title('Magnitude')
  grid
  subplot(5,2,4)
  semilogx(SG_FREQ_100, SG_PHAS_100)
  title('Phase')
  grid
  
  subplot(5,2,5)
  semilogx(SG_FREQ_500, SG_GAIN_500)
  title('Magnitude')
  grid
  subplot(5,2,6)
  semilogx(SG_FREQ_500, SG_PHAS_500)
  title('Phase')
  grid
  
  subplot(5,2,7)
  semilogx(SG_FREQ_1000, SG_GAIN_1000)
  title('Magnitude')
  grid
  subplot(5,2,8)
  semilogx(SG_FREQ_1000, SG_PHAS_1000)
  title('Phase')
  grid
  
  subplot(5,2,9)
  semilogx(SG_FREQ_2000, SG_GAIN_2000)
  title('Magnitude')
  grid
  subplot(5,2,10)
  semilogx(SG_FREQ_2000, SG_PHAS_2000)
  title('Phase')
  grid
end

%Reading data from homemade software
if true
  cd 'Homemade Software'
  [HM_GAIN_1, HM_PHASE_1, HM_FREQ_1] = BodeData('FrqRes_1,3A_60867D.csv');
  [HM_GAIN_2, HM_PHASE_2, HM_FREQ_2] = BodeData('FrqRes_1.3A_91304D.csv');
  [HM_GAIN_3, HM_PHASE_3, HM_FREQ_3] = BodeData('FrqRes_7A_45658D.csv');
  [HM_GAIN_4, HM_PHASE_4, HM_FREQ_4] = BodeData('FrqRes_7A_78048D.csv');
  [HM_GAIN_5, HM_PHASE_5, HM_FREQ_5] = BodeData('FrqRes_12A_45653D.csv');  
  cd ..
  
  figure
  subplot(6,2,1)
  semilogx(HM_FREQ_1, HM_GAIN_1)
  title('Magnitude')
  grid
  subplot(6,2,2)
  semilogx(HM_FREQ_1, HM_PHASE_1)
  title('Phase')
  grid
  
  subplot(6,2,3)
  semilogx(HM_FREQ_2, HM_GAIN_2)
  title('Magnitude')
  grid
  subplot(6,2,4)
  semilogx(HM_FREQ_2, HM_PHASE_2)
  title('Phase')
  grid
  
  subplot(6,2,5)
  semilogx(HM_FREQ_3, HM_GAIN_3)
  title('Magnitude')
  grid
  subplot(6,2,6)
  semilogx(HM_FREQ_3, HM_PHASE_3)
  title('Phase')
  grid
  
  subplot(6,2,7)
  semilogx(HM_FREQ_4, HM_GAIN_4)
  title('Magnitude')
  grid
  subplot(6,2,8)
  semilogx(HM_FREQ_4, HM_PHASE_4)
  title('Phase')
  grid
  
  subplot(6,2,9)
  semilogx(HM_FREQ_5, HM_GAIN_5)
  title('Magnitude')
  grid
  subplot(6,2,10)
  semilogx(HM_FREQ_5, HM_PHASE_5)
  title('Phase')
  grid
  
  %  subplot(6,2,11)
  %  semilogx(HM_FREQ_6, HM_GAIN_6)
  %  title('Magnitude')
  %  grid
  %  subplot(6,2,12)
  %  semilogx(HM_FREQ_6, HM_PHASE_6)
  %  title('Phase')
  %  grid
end
