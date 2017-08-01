clear, close all, clc
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