Program Pzim ;
	var sorteio							 		:array[1..60] of integer;
			aposta, dezena,i, j, i2, j2, aux:integer;	 
Begin

	writeln('----MEGA SENA----');
	writeln;
	
	write('Digite o n�mero de dezenas: ');
	readln(dezena);
	
	write('Digite o n�mero de apostas: ');
	readln(aposta);
	
	
	
	if ((dezena = 0) or (aposta = 0) or (dezena < 0) or (aposta < 0)) then 
		begin
   		writeln('Digite algum n�mero maior que 0 nos campos aposta e dezena');
 		end 
 	else 
	 	begin
	 	writeln;
		writeln('N�meros sorteados: ');
		writeln;
   		for i := 1 to aposta do
 				begin
 				
 					{c�digo para gerar as dezenas}
   				for j := 1 to dezena do
     				begin
     					sorteio[j]:= random(60)+1;
     				end;
						 
					{ordena��o}			
      		for i2 := 1 to dezena do
  					begin
  						for j2 := 1 to dezena - 1 do
    						begin
      						if (sorteio[j2] > sorteio[j2+1]) then 
										begin
											aux:= sorteio[j2];
											sorteio[j2]:= sorteio[j2+1];
											sorteio[j2+1]:= aux;
        						end;
    						end;
  					end;
  				{mostra os n�meros sorteados}
  				for j := 1 to dezena do
    				begin           	
      				write(sorteio[j]:3,' ');
    				end;
      			writeln;
 				end;	
 		end;
 		writeln;
 		
 		
 		readln;
  
End.