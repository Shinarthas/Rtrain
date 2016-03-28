function [X] = MyEval(x,y,z)
fis = readfis('analiz');
[output, IRR, ORR, ARR]= evalfis([x y z],fis); 
X(1)=sum(IRR(1,:))/3;
X(2)=sum(IRR(2,:))/3;
X(3)=sum(IRR(3,:))/3;
X(4)=sum(IRR(4,:))/3;
end