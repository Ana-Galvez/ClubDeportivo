-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.32-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para proyecto
CREATE DATABASE IF NOT EXISTS `proyecto` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `proyecto`;

-- Volcando estructura para tabla proyecto.cliente
CREATE TABLE IF NOT EXISTS `cliente` (
  `IDCliente` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) NOT NULL,
  `Apellido` varchar(40) NOT NULL,
  `FechaNacimiento` date NOT NULL,
  `DNI` int(11) NOT NULL,
  `Genero` enum('F','M','Prefiero no decir') NOT NULL,
  `Direccion` varchar(60) NOT NULL,
  `Telefono` varchar(30) NOT NULL,
  `FechaInscripcion` date NOT NULL,
  `AptoFisico` tinyint(4) NOT NULL,
  `Socio` tinyint(4) NOT NULL,
  PRIMARY KEY (`IDCliente`),
  UNIQUE KEY `DNI` (`DNI`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.cliente: ~3 rows (aproximadamente)
INSERT INTO `cliente` (`IDCliente`,`Nombre`, `Apellido`, `FechaNacimiento`, `DNI`, `Genero`, `Direccion`, `Telefono`, `FechaInscripcion`, `AptoFisico`, `Socio`) VALUES
	(1,'Vir', 'Cardoso', '1983-06-02', 30001294, 'F', 'Rep siria 2705', '2914634607', '2025-05-12', 1, 1),
	(2,'ana', 'card', '1983-05-10', 30351293, 'F', 'aa', '111', '2025-05-12', 1, 0),
	(3,'11', '11', '1984-05-12', 11, 'F', '1111', '111', '2025-05-12', 1, 1);

-- Volcando estructura para procedimiento proyecto.IngresoLogin
DELIMITER //
CREATE PROCEDURE `IngresoLogin`(in Usu varchar(20),in Pass varchar(15))
begin
  /* En la consulta muestra el rol que posee esa persona si existe */
  
  select u.NombreUsu, r.NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and PassUsu = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */


end//
DELIMITER ;

-- Volcando estructura para procedimiento proyecto.NuevoCliente
DELIMITER //
CREATE PROCEDURE `NuevoCliente`(
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
         -- Insertar en tabla socios o no_socio según valor de p_Socio
        IF p_Socio = 1 THEN
            INSERT INTO socios (IDCliente, FechaAltaSocio)
            VALUES (nuevoID, p_FechaInscripcion);
        ELSE
            INSERT INTO noSocios (IDCliente, FechaAltaNoSocio)
            VALUES (nuevoID, p_FechaInscripcion);
        END IF;

        SET rta = nuevoID;

    ELSE
        -- Si el DNI ya existe, devolvemos -1 como señal
        SET rta = -1;
    END IF;
END//
DELIMITER ;

-- Volcando estructura para tabla proyecto.roles
CREATE TABLE IF NOT EXISTS `roles` (
  `RolUsu` int(11) NOT NULL,
  `NomRol` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`RolUsu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.roles: ~2 rows (aproximadamente)
INSERT INTO `roles` (`RolUsu`, `NomRol`) VALUES
	(120, 'Administrador'),
	(121, 'Empleado');

-- Volcando estructura para tabla proyecto.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `CodUsu` int(11) NOT NULL AUTO_INCREMENT,
  `NombreUsu` varchar(20) DEFAULT NULL,
  `PassUsu` varchar(15) DEFAULT NULL,
  `RolUsu` int(11) DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT 1,
  PRIMARY KEY (`CodUsu`),
  KEY `fk_usuario` (`RolUsu`),
  CONSTRAINT `fk_usuario` FOREIGN KEY (`RolUsu`) REFERENCES `roles` (`RolUsu`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.usuario: ~0 rows (aproximadamente)
INSERT INTO `usuario` (`CodUsu`,`NombreUsu`, `PassUsu`, `RolUsu`, `Activo`) VALUES
	(1, 'Ana', '123456', 120, 1);

-- Volcando datos para el procedure verificarClienteID
  	DELIMITER //
CREATE PROCEDURE `VerificarClienteID`(
    IN p_ClienteID INT
)
BEGIN
-- Busco el id de cliente en la tabla cliente, devuelve el valor si existe
    SELECT IDCliente FROM cliente WHERE IDCliente = p_ClienteID;
END//
DELIMITER ;

-- Volcando datos para el procedure VerificarClienteIDYBooleanSocio, para obtener si el cliente esta registrado y es o no socio
DELIMITER $$

CREATE PROCEDURE VerificarClienteIDYBooleanSocio(IN p_ClienteID INT)
BEGIN
    DECLARE vExiste BOOL DEFAULT FALSE;

    SELECT COUNT(*) > 0 INTO vExiste FROM cliente WHERE IDCliente = p_ClienteID;

    IF vExiste THEN
        SELECT TRUE AS Existe, socio AS EsSocio
        FROM cliente
        WHERE IDCliente = p_ClienteID;
    ELSE
        SELECT FALSE AS Existe, FALSE AS EsSocio FROM DUAL;
    END IF;
END$$

DELIMITER ;


/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;

-- Volcando estructura para la tabla proyecto.socios 
CREATE TABLE IF NOT EXISTS `socios` (
  `IDCliente` INT(11) NOT NULL,
  `FechaAltaSocio` DATE NOT NULL,
  PRIMARY KEY (`IDCliente`),
  CONSTRAINT `fk_socio_cliente`
    FOREIGN KEY (`IDCliente`) REFERENCES `cliente`(`IDCliente`)
    ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.socios 
INSERT INTO socios (IDCliente, FechaAltaSocio) VALUES
(1, '2025-05-10'),
(3,'2025-05-15');

-- Volcando estructura para la tabla proyecto.cuotas
CREATE TABLE IF NOT EXISTS `Cuotas` (
  `IdCuota` INT(11) NOT NULL AUTO_INCREMENT,
  `IDCliente` INT(11) NOT NULL,
  `Monto` DECIMAL(10,2) NOT NULL,
  `ModoPago` ENUM('Efectivo', 'Tarjeta', 'Transferencia') NOT NULL,
  `Estado` ENUM('Pagada', 'Pendiente') NOT NULL,
  `FechaPago` DATE NOT NULL,
  `FechaVencimiento` DATE NOT NULL,
  PRIMARY KEY (`IdCuota`),
  CONSTRAINT `fk_cuota_cliente` FOREIGN KEY (`IDCliente`) REFERENCES `cliente`(`IDCliente`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.cuotas 
INSERT INTO Cuotas (IDCliente, Monto, ModoPago, Estado, FechaPago, FechaVencimiento) VALUES
(1, 1500.00, 'Efectivo', 'Pagada', '2025-05-10', '2025-06-10'),
(3, 1200.00, 'Efectivo', 'Pendiente', '2025-05-15', '2025-06-10');

CREATE TABLE IF NOT EXISTS noSocios (
  IDCliente INT(11) NOT NULL,
  FechaAltaNoSocio DATE NOT NULL DEFAULT (CURDATE()),
  PRIMARY KEY (IDCliente),
  CONSTRAINT fk_nosocio_cliente
    FOREIGN KEY (IDCliente) REFERENCES cliente(IDCliente)
    ON DELETE CASCADE
);

-- Volcando datos para la tabla proyecto.socios 
INSERT INTO noSocios (IDCliente, FechaAltaNoSocio) VALUES
(2, '2025-05-10');

CREATE TABLE IF NOT EXISTS actividades (
  IDActividad INT AUTO_INCREMENT PRIMARY KEY,
  Nombre VARCHAR(50) NOT NULL,
  DiaSemana VARCHAR(15) NOT NULL,
  Hora TIME,
  Precio DECIMAL(10,2) NOT NULL
);

CREATE TABLE IF NOT EXISTS pago_actividad (
  IdPagoActividad INT AUTO_INCREMENT PRIMARY KEY,
  IDCliente INT NOT NULL,
  IdActividad INT NOT NULL,
  FechaPago DATE NOT NULL DEFAULT (CURRENT_DATE),
  ModoPago ENUM('Efectivo', 'Tarjeta', 'Transferencia') NOT NULL DEFAULT 'Efectivo',
  Monto DECIMAL(10,2) NOT NULL,
  Estado ENUM('Pagada', 'Pendiente') NOT NULL DEFAULT 'Pendiente',
  FOREIGN KEY (IDCliente) REFERENCES cliente(IDCliente) ON DELETE CASCADE,
  FOREIGN KEY (IdActividad) REFERENCES actividades(IdActividad) ON DELETE CASCADE
);

INSERT INTO actividades (Nombre, DiaSemana, Hora, Precio) VALUES
('Natación', 'Lunes', '11:00:00', 5000),
('Natación', 'Jueves', '15:00:00', 5000),
('Pilates', 'Lunes', '18:00:00', 8000),
('Pilates', 'Miércoles', '12:00:00', 8000),
('Tenis', 'Miércoles', '18:00:00', 10000),
('Tenis', 'Viernes', '20:00:00', 10000),
('Musculación', 'Martes', '19:00:00', 5000),
('Musculación', 'Jueves', '19:00:00', 5000),
('Yoga', 'Lunes', '16:00:00', 5000),
('Yoga', 'Miércoles', '16:00:00', 5000),
('Aerobic', 'Martes', '18:00:00', 5000),
('Aerobic', 'Jueves', '12:00:00', 5000),
('Danza', 'Lunes', '19:00:00', 8000),
('Danza', 'Miércoles', '19:00:00', 8000),
('Danza', 'Viernes', '19:00:00', 8000),
('Danza', 'Lunes', '11:00:00', 8000),
('Danza', 'Miércoles', '11:00:00', 8000),
('Danza', 'Viernes', '11:00:00', 8000);