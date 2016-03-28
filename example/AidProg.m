function [X,Fval] = AidProg(f,A,b,lb,ub)
[x,fval] = linprog(f,A,b,[],[],lb,ub);
X=x;
Fval=fval;
end