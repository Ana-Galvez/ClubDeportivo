 delimiter //
 create procedure NuevoCliente(
	in IDCli int,
  in Nom varchar(30),
  in Ape varchar(40),
  in FechaNac date, 
  in Doc int, 
  in Gen enum('F','M','Prefiero no decir'), 
  in Dir varchar(60), in Tel varchar(30), 
  in FechaInsc date, 
  in AptoF tinyint, 
  in Soc tinyint, 
  out rta int
)
 begin
    declare filas int default 0;
    declare existe int default 0;
    
     set filas = (select count(*) from cliente);
     if filas = 0 then
	set filas = 1; /* consideramos a este numero como el primer numero de postulante */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de postulante almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
	set filas = (select max(IDCliente) + 1 from cliente);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el postulante
		------------------------------------------------------- */	
	set existe = (select count(*) from cliente where DNI = doc and IDCliente = IDCli);
      end if;
	 
      if existe = 0 then	 
	insert into cliente 
     	values(filas,IDCli,Nom,Ape,FechaNac,Doc,Gen,Dir,Tel,FechaInsc,AptoF,Soc);
	set rta  = filas;
      else
	set rta = existe;
      end if;		 
end //
		end if;		 
end //