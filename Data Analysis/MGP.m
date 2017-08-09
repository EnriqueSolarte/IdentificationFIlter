clear, close all, clc

if true
  cd 'Data CW'
%  [HM_GAIN, HM_PHASE, HM_FREQ] = BodeData('SoftwareTimeResponse1.csv');
    file = csvread('ServoGuideFrequencyResponse1.csv');
    HM_FREQ  = file([5:end],2);
    HM_PHASE = file([5:end],4);
    HM_GAIN  = file([5:end],3);
  cd ..
    
  # ##### PHASE MARGIN #####
  gain_threshold = 0;
  j = 2;
  cross_gain = [0, 0, 0];
  HM_GAIN = HM_GAIN .+ 3;
  for i = 1:length(HM_GAIN)-1
    if (sign(HM_GAIN(i)) != sign(HM_GAIN(i+1)))
      if (abs(HM_GAIN(i)) > gain_threshold || abs(HM_GAIN(i+1)) > gain_threshold)
        cross_gain = [cross_gain; i ,HM_FREQ(i), HM_FREQ(i+1)];
      end
    end
  end  
  cross_gain(1,:) = [];
  
  if isempty(cross_gain)
    phase_margin = inf;
    freq_gain = inf;
    phase_MP = 0;
    else
    for i = 1:length(cross_gain(:,1))
      a = HM_PHASE(cross_gain(i,1));
      b = HM_PHASE(cross_gain(i,1)+1);
      c = (a + b)/2;
      if c > -180
        phase_margin(i,1) = -(- 180 - c);
        else
        phase_margin(i,1) = +(+ 180 + c);
      end
      freq_gain(i,1) = (cross_gain(i,2) + cross_gain(i,3))/2;
    end
  end
  
  [PM, iPM] = min(phase_margin);
  FPM = freq_gain(iPM);
 
 
  # ##### GAIN MARGIN #####
  phase_threshold = 0;
  cross_phase = [0, 0, 0];
  HM_PHASE = HM_PHASE .+ 180;
  for i = 1:length(HM_PHASE)-1
    if (sign(HM_PHASE(i)) != sign(HM_PHASE(i+1)))
      if (abs(HM_PHASE(i) > phase_threshold || abs(HM_PHASE(i+1)) > phase_threshold))
        cross_phase = [cross_phase; i, HM_FREQ(i), HM_FREQ(i+1)];
      end
    end
  end
  cross_phase(1,:) = [];
  
  if isempty(cross_phase)
    gain_margin = inf;
    freq_phase = inf;
    gain_MG = 0;
    else
    for i = 1:length(cross_phase(:,1))
      a = HM_GAIN(cross_phase(i,1));
      b = HM_GAIN(cross_phase(i,1)+1);
      c = (a + b)/2;
      if c > -3
        gain_margin(i,1) = +(+ 3 - c);
        else
        gain_margin(i,1) = -(- 3 + c);
      end
      freq_phase(i,1) = (cross_phase(i,2) + cross_phase(i,3))/2;
    end
  end
  
  [GM, iGM] = min(gain_margin);
  FGM = freq_phase(iGM);
  
  if true
    HM_PHASE = HM_PHASE .- 180;
    HM_GAIN = HM_GAIN .- 3;
    R = 2;
    C = 1;
    subplot(R,C,1);
    hold on;
    semilogx(HM_FREQ, HM_GAIN);
    title('Magnitude');
    line([FGM, FGM], [-3, -GM]);
    line([1, 1000], [-3, -3],'Color','red','LineStyle','--');
    label = ['GM: ', num2str(GM), ', Freq: ', num2str(FGM)];
    if FGM == inf
      text(1, 0, label);
      else
      text(FGM, 0, label,'HorizontalAlignment','right');
    end
    grid;
    subplot(R,C,2);
    hold on;
    semilogx(HM_FREQ, HM_PHASE);
    title('Phase');
    line([FPM, FPM], [-180+PM, -180]);
    line([1, 1000], [-180, -180],'Color','red','LineStyle','--');
    label = ['PM: ', num2str(PM), ', Freq: ', num2str(FPM)];
    if FPM == inf
      text(1, -180, label);
      else
      text(FPM, -180, label);
    end
    grid;
%    figure
%    plot(HM_PHASE, HM_GAIN)
%    title('Nichols Plot')
%    xlabel('Phase')
%    ylabel('Gain')
%    grid
  end
end

PM
FPM
GM
FGM