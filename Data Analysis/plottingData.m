function plottingData(FrequencyResponseServoguide,TimeResponseOwnsoftware)
  %Data in Frequency Domain from servoguide
    SG_FREQUENCY=FrequencyResponseServoguide(:,2);
    SG_GAIN=FrequencyResponseServoguide(:,3);
    SG_PHASE=FrequencyResponseServoguide(:,4);
    
%  %Data in Time Domain from own software
%    OS_TCMD=TimeResponseOwnsoftware(:,1);
%    OS_FRTCM=TimeResponseOwnsoftware(:,2);
%    OS_FREQUENCY=TimeResponseOwnsoftware(:,3);
%    OS_TIME=0:0.25:(length(OS_FREQUENCY)-1)*0.25;
%  
%  %Data in Frequency Domain from own software
%    OS_FREQUENCY=FrequencyResponseOwnsoftware(:,1);
%    OS_GAIN=FrequencyResponseOwnsoftware(:,2);
%    OS_PHASE=FrequencyResponseOwnsoftware(:,3);
% 

  %Plotting Time Domain 
    %Plotting OS_TCMD
    subplot(3,2,1)
    plot(OS_TIME,OS_TCMD)
    title('TCMD vs TIME')
    ylabel('TCMD')
    xlabel('TIME')
    ylim([-20,20])
    grid
    
    %Plotting OS_FRTCM
    subplot(3,2,2)
    plot(OS_TIME,OS_FRTCM)
    title('FRTCM vs TIME')
    ylabel('FRTCM')
    xlabel('TIME')
    ylim([-20,20])
    grid
  
  %Plotting Frequency Domain from servoguide file
    %Plotting gain 
    subplot(3,2,3)
    semilogx(SG_FREQUENCY,SG_GAIN)
    title('GAIN vs FREQUENCY')
    ylabel('GAIN')
    xlabel('FREQUENCY')
    grid

    %Plotting phase 
    subplot(3,2,5)
    semilogx(SG_FREQUENCY,SG_PHASE)
    title('PHASE vs FREQUENCY')
    ylabel('PHASE')
    xlabel('FREQUENCY')
    grid    

  %Plotting Frequency Domain from processed data file
    %Plotting gain 
    subplot(3,2,4)
    semilogx(OS_FREQUENCY,OS_GAIN,'r')
    title('GAIN vs FREQUENCY')
    ylabel('GAIN')
    xlabel('FREQUENCY')
    grid

    %Plotting phase 
    subplot(3,2,6)
    semilogx(OS_FREQUENCY,OS_PHASE,'r')
    title('PHASE vs FREQUENCY')
    ylabel('PHASE')
    xlabel('FREQUENCY')
    grid    

  endfunction