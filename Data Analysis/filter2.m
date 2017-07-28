close all

u
max(u)

for i = 1:length(u)
  abs(u(i))
  u(i)*conj(u(i))
end