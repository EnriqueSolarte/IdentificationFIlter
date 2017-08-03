function [MagData, PhaseData, FreqData] = BodeData(File_with_data)

TimeResponseOwnsoftware=csvread(File_with_data);   
  OS_TCMD=TimeResponseOwnsoftware(2:end,1);
  OS_FRTCM=TimeResponseOwnsoftware(2:end,2);
  OS_FREQUENCY=TimeResponseOwnsoftware(2:end,3);
  OS_TIME=0:0.25:(length(OS_FREQUENCY)-1)*0.25;
  
j=1;
for i=1:length(OS_FREQUENCY)-1
  if OS_FREQUENCY(i) != OS_FREQUENCY(i+1) || i == length(OS_FREQUENCY)-1
    FREQUENCIES(j)=OS_FREQUENCY(i);
    j=j+1;
  end
end

j=1;
aux_OS_TCMD = [];
aux_OS_FRTCM = [];
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

    MAXS = [MAXS;FREQUENCIES(j), max_OS_FRTCM, max_OS_TCMD];
    aux_OS_TCMD = [];
    aux_OS_FRTCM = [];
    aux_OS_TCMD = [aux_OS_TCMD; OS_TCMD(i)];
    aux_OS_FRTCM = [aux_OS_FRTCM; OS_FRTCM(i)];
    j=j+1;
  end
end

MAXS = [MAXS;FREQUENCIES(j), max_OS_FRTCM, max_OS_TCMD];

H = MAXS(:,3)./MAXS(:,2);
FreqData = MAXS(:,1);
MagData = 20*log10(abs(H));

x = real(H);
y = imag(H);
for i = 1:length(x)
  if y(i)==0 && x(i)==0
    v(i) = 0;
  end
  
  if x(1)>0
    v(i)=atan(y(i)/x(i));
  end
  
  if y(i)>=0 && x(i)<0
    v(i)=pi+atan(y(i)/x(i));
  end
  
  if y(i)<0 && x(i)<0
    v(i)=-pi+atan(y(i)/x(i));
  end
  
  if y(i)>0 && x(i)==0
    v(i)=pi/2;
  end
  
  if y(i)<0 && x(i)==0
    v(i)=-pi/2;
  end
  
  if v(i)<0
    v(i)=v(i)+2*pi;
  end
end

PhaseData = (v-2*pi)*180/pi;


