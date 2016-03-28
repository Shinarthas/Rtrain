function [vvvvv] = FforDiag(x)
f=fopen('ll.txt','r');
[X,count]=fscanf (f,'%f, %f, %f, %f, %f, %f, %f, %f, %f', [9 inf]);
count;
X=X';
X=X(1:50,3:5);
ss=size(X);
diag=4;

nameOfVars = ['��������������         '; '�������������� ��������'; '������ �������          '];
nameOfDiag = ['�����     '; '��������  '; '����������'; '���       ';];
fs=newfis('analiz','mamdani');
for inVar = 1:ss(2)
    %fs=addvar(fs,'input',nameOfVars(inVar,:),[min(X(:,inVar)) max(X(:,inVar))]);
    fs=addvar(fs,'input',nameOfVars(inVar,:),[min(X(:,inVar)) max(X(:,inVar))]);
end
fs=addmf(fs,'input',1,'�����     ','trapmf',[0,0,35,50]);
fs=addmf(fs,'input',1,'��������  ','trapmf',[35,50,60,70]);
fs=addmf(fs,'input',1,'����������','trapmf',[60,70,80,90]);
fs=addmf(fs,'input',1,'���       ','trapmf',[80,100,110,200]);

fs=addmf(fs,'input',2,'�����     ','trapmf',[0,0,15,20]);
fs=addmf(fs,'input',2,'��������  ','trapmf',[15,20,25,30]);
fs=addmf(fs,'input',2,'����������','trapmf',[25,30,35,40]);
fs=addmf(fs,'input',2,'���       ','trapmf',[35,40,47,80]);

fs=addmf(fs,'input',3,'�����     ','trapmf',[0,0,197,400]);
fs=addmf(fs,'input',3,'��������  ','trapmf',[197,400,500,560]);
fs=addmf(fs,'input',3,'����������','trapmf',[500,560,600,700]);
fs=addmf(fs,'input',3,'���       ','trapmf',[600,700,846,1000]);

fs=addvar(fs,'output','Diagnosis',[0 10]);
fs=addmf(fs,'output',1,'�����     ','trapmf',[0 0 6 7]);
fs=addmf(fs,'output',1,'��������  ','trapmf',[6 7 7 8]);
fs=addmf(fs,'output',1,'����������','trapmf',[7 8 8 9]);
fs=addmf(fs,'output',1,'���       ','trapmf',[8 9 9 10]);



fs=addrule(fs,[1 1 1 1 1 1]);
fs=addrule(fs,[2 2 2 2 1 1]);
fs=addrule(fs,[3 3 3 3 1 1]);
fs=addrule(fs,[4 4 4 4 1 1]);
fuzzy(fs);
vvvvv=1;
end



