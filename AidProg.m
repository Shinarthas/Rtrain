function [X,Fval] = AidProg(f,A,b,Aeq,beq,lb,ub)


[x,fval] = linprog(f,A,b,Aeq,beq,lb,ub);
X=x;
Fval=fval;
end