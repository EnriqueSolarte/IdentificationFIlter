%clear, close all, clc

TIME = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
VALUE = [0.39, 0.50, 0.48, 0.29, 0.25, 0.32, 0.34, 0.48, 0.41, 0.45];

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

%Xest=[PhaseData(index-1)];
Xest = [0];
Pest=[1];
%Z=auxPD;
Z= OS_TCMD;
R = 1;
Q = 0.1;

for i = 1:length(OS_TCMD)
  % Prediction
  Xestm(i) = Xest(i);
  Pestm(i) = Pest(i)+Q;
  % Correction
  K(i) = Pestm(i)/(Pestm(i) + R);
  Xest(i+1)=Xestm(i) + K(i)*(Z(i)-Xestm(i));
  Pest(i+1)=(1-K(i))*Pestm(i);
end

%PhaseData1 = PhaseData;
%PhaseData1(index:length(PhaseData1)) = Xest(2:end);
PhaseData1 = Xest;

%PhaseData = Xest(2:end);
figure
%  subplot(2,3,6)
%semilogx(f,PhaseData1)
%title('Phase')
%hold on
%semilogx(SG_FREQUENCY,SG_PHASE,'r')
%grid
%hold off
plot(OS_TCMD,'r')
hold on
plot(PhaseData1(2:end),'b')