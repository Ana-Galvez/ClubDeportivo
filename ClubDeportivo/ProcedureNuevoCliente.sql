DELIMITER //

CREATE PROCEDURE NuevoCliente(
    IN p_Nombre VARCHAR(30),
    IN p_Apellido VARCHAR(40),
    IN p_FechaNacimiento DATE,
    IN p_DNI INT,
    IN p_Genero VARCHAR(20),
    IN p_Direccion VARCHAR(60),
    IN p_Telefono VARCHAR(30),
    IN p_FechaInscripcion DATE,
    IN p_AptoFisico BOOLEAN,
    IN p_Socio BOOLEAN,
    OUT rta INT
)
BEGIN
    DECLARE existe INT DEFAULT 0;
    DECLARE nuevoID INT DEFAULT 0;

    -- Verificamos si ya existe el cliente con ese DNI
    SET existe = (SELECT COUNT(*) FROM cliente WHERE DNI = p_DNI);

    IF existe = 0 THEN
        INSERT INTO cliente (
            Nombre, Apellido, FechaNacimiento, DNI, Genero,
            Direccion, Telefono, FechaInscripcion, AptoFisico, Socio
        ) VALUES (
            p_Nombre, p_Apellido, p_FechaNacimiento, p_DNI, p_Genero,
            p_Direccion, p_Telefono, p_FechaInscripcion, p_AptoFisico, p_Socio
        );

        -- Obtenemos el ID autogenerado
        SET nuevoID = LAST_INSERT_ID();
        SET rta = nuevoID;

    ELSE
        -- Si el DNI ya existe, devolvemos -1
        SET rta = -1;
    END IF;
END;
//

DELIMITER ;
