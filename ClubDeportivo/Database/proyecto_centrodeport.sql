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
DROP DATABASE IF EXISTS `proyecto`;
CREATE DATABASE IF NOT EXISTS `proyecto` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `proyecto`;

-- Volcando estructura para tabla proyecto.actividades
CREATE TABLE IF NOT EXISTS `actividades` (
  `IDActividad` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  `DiaSemana` varchar(15) NOT NULL,
  `Hora` time DEFAULT NULL,
  `Precio` decimal(10,2) NOT NULL,
  PRIMARY KEY (`IDActividad`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.actividades: ~18 rows (aproximadamente)
INSERT INTO `actividades` (`IDActividad`, `Nombre`, `DiaSemana`, `Hora`, `Precio`) VALUES
	(1, 'Natación', 'Lunes', '11:00:00', 5000.00),
	(2, 'Natación', 'Jueves', '15:00:00', 5000.00),
	(3, 'Pilates', 'Lunes', '18:00:00', 8000.00),
	(4, 'Pilates', 'Miércoles', '12:00:00', 8000.00),
	(5, 'Tenis', 'Miércoles', '18:00:00', 10000.00),
	(6, 'Tenis', 'Viernes', '20:00:00', 10000.00),
	(7, 'Musculación', 'Martes', '19:00:00', 5000.00),
	(8, 'Musculación', 'Jueves', '19:00:00', 5000.00),
	(9, 'Yoga', 'Lunes', '16:00:00', 5000.00),
	(10, 'Yoga', 'Miércoles', '16:00:00', 5000.00),
	(11, 'Aerobic', 'Martes', '18:00:00', 5000.00),
	(12, 'Aerobic', 'Jueves', '12:00:00', 5000.00),
	(13, 'Danza', 'Lunes', '19:00:00', 8000.00),
	(14, 'Danza', 'Miércoles', '19:00:00', 8000.00),
	(15, 'Danza', 'Viernes', '19:00:00', 8000.00),
	(16, 'Danza', 'Lunes', '11:00:00', 8000.00),
	(17, 'Danza', 'Miércoles', '11:00:00', 8000.00),
	(18, 'Danza', 'Viernes', '11:00:00', 8000.00);

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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.cliente: ~7 rows (aproximadamente)
INSERT INTO `cliente` (`IDCliente`, `Nombre`, `Apellido`, `FechaNacimiento`, `DNI`, `Genero`, `Direccion`, `Telefono`, `FechaInscripcion`, `AptoFisico`, `Socio`) VALUES
	(1, 'Virginia', 'Lopez', '1983-06-02', 30001294, 'F', 'Rep siria 2705', '29144111011', '2025-05-12', 1, 1),
	(2, 'Ana', 'Marinez', '1983-05-10', 29456874, 'F', 'Otra calle', '2456874521', '2025-05-04', 1, 0),
	(3, 'Matias', 'Fernandez', '1984-01-12', 45218754, 'M', 'Mi direc 125 Depto 5', '2459874512', '2025-05-12', 1, 1),
	(5, 'Fernado', 'Sanchez', '1988-08-07', 9876543, 'M', 'calle 123', '291454687', '2025-06-07', 1, 0),
	(6, 'Julia', 'Montes', '1995-05-28', 45023032, 'F', 'call1 122', '12456987', '2025-06-16', 1, 1),
	(7, 'Julio', 'Amigo', '1980-06-16', 28456785, 'Prefiero no decir', 'Direccion 234 Barrio 4', '29245871256', '2025-06-15', 1, 0),
	(8, 'Manuel', 'Martinez', '1990-06-16', 29854212, 'M', 'calle 123', '11548756123', '2025-06-16', 1, 1);

-- Volcando estructura para tabla proyecto.cuotas
CREATE TABLE IF NOT EXISTS `cuotas` (
  `IdCuota` int(11) NOT NULL AUTO_INCREMENT,
  `IDCliente` int(11) NOT NULL,
  `Monto` decimal(10,2) NOT NULL,
  `ModoPago` enum('Efectivo','Tarjeta','Transferencia') DEFAULT NULL,
  `Estado` enum('Pagada','Pendiente') NOT NULL,
  `FechaPago` date DEFAULT NULL,
  `FechaVencimiento` date NOT NULL,
  `CantCuotas` int(3) DEFAULT 0 COMMENT 'Pago tarjeta, cant cuotas',
  `UltDigitosTarj` int(10) DEFAULT 0 COMMENT 'Ult digitos tarjeta',
  PRIMARY KEY (`IdCuota`),
  KEY `fk_cuota_cliente` (`IDCliente`),
  CONSTRAINT `fk_cuota_cliente` FOREIGN KEY (`IDCliente`) REFERENCES `cliente` (`IDCliente`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.cuotas: ~7 rows (aproximadamente)
INSERT INTO `cuotas` (`IdCuota`, `IDCliente`, `Monto`, `ModoPago`, `Estado`, `FechaPago`, `FechaVencimiento`, `CantCuotas`, `UltDigitosTarj`) VALUES
	(1, 1, 1500.00, 'Tarjeta', 'Pagada', '2025-06-07', '2025-06-11', 3, 1234),
	(2, 3, 1200.00, 'Transferencia', 'Pagada', '2025-06-07', '2025-06-10', 0, 0),
	(4, 3, 1200.00, NULL, 'Pendiente', NULL, '2025-06-20', 0, 0),
	(7, 1, 1500.00, NULL, 'Pendiente', NULL, '2025-06-21', 0, 0),
	(8, 6, 150000.00, NULL, 'Pendiente', NULL, '2025-06-20', 0, 0),
	(13, 8, 150000.00, 'Efectivo', 'Pagada', '2025-05-17', '2025-05-17', 0, 0),
	(15, 8, 150000.00, NULL, 'Pendiente', NULL, '2025-06-20', 0, 0);

-- Volcando estructura para procedimiento proyecto.IngresoLogin
DELIMITER //
CREATE PROCEDURE `IngresoLogin`(
	IN `Usu` varchar(20),
	IN `Pass` varchar(15)
)
begin
  /* En la consulta muestra el rol que posee esa persona si existe */
  
  select u.NombreUsu, r.NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		WHERE BINARY NombreUsu = Usu and BINARY PassUsu = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */


end//
DELIMITER ;

-- Volcando estructura para tabla proyecto.nosocios
CREATE TABLE IF NOT EXISTS `nosocios` (
  `IDCliente` int(11) NOT NULL,
  `FechaAltaNoSocio` date NOT NULL DEFAULT curdate(),
  PRIMARY KEY (`IDCliente`),
  CONSTRAINT `fk_nosocio_cliente` FOREIGN KEY (`IDCliente`) REFERENCES `cliente` (`IDCliente`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.nosocios: ~2 rows (aproximadamente)
INSERT INTO `nosocios` (`IDCliente`, `FechaAltaNoSocio`) VALUES
	(2, '2025-05-10'),
	(7, '2025-06-16');

-- Volcando estructura para procedimiento proyecto.NuevoCliente
DELIMITER //
CREATE PROCEDURE `NuevoCliente`(
	IN `p_Nombre` VARCHAR(30),
	IN `p_Apellido` VARCHAR(40),
	IN `p_FechaNacimiento` DATE,
	IN `p_DNI` INT,
	IN `p_Genero` VARCHAR(20),
	IN `p_Direccion` VARCHAR(60),
	IN `p_Telefono` VARCHAR(30),
	IN `p_FechaInscripcion` DATE,
	IN `p_AptoFisico` BOOLEAN,
	IN `p_Socio` BOOLEAN,
	OUT `rta` INT
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
            
            -- Creoamos la cuota inicial
	        INSERT INTO `cuotas` ( `IDCliente`, `Monto`, `ModoPago`, `Estado`, `FechaPago`, `FechaVencimiento`, `CantCuotas`, `UltDigitosTarj`) 
			  VALUES ( nuevoID, 150000.00, NULL, 'Pendiente', NULL, DATE_ADD(CURDATE(), INTERVAL 1 MONTH), 0, 0);
			  
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

-- Volcando estructura para tabla proyecto.pago_actividad
CREATE TABLE IF NOT EXISTS `pago_actividad` (
  `IdPagoActividad` int(11) NOT NULL AUTO_INCREMENT,
  `IDCliente` int(11) NOT NULL,
  `IdActividad` int(11) NOT NULL,
  `FechaPago` date NOT NULL DEFAULT curdate(),
  `ModoPago` enum('Efectivo','Tarjeta','Transferencia') NOT NULL DEFAULT 'Efectivo',
  `Monto` decimal(10,2) NOT NULL,
  `Estado` enum('Pagada','Pendiente') NOT NULL DEFAULT 'Pendiente',
  PRIMARY KEY (`IdPagoActividad`),
  KEY `IDCliente` (`IDCliente`),
  KEY `IdActividad` (`IdActividad`),
  CONSTRAINT `pago_actividad_ibfk_1` FOREIGN KEY (`IDCliente`) REFERENCES `cliente` (`IDCliente`) ON DELETE CASCADE,
  CONSTRAINT `pago_actividad_ibfk_2` FOREIGN KEY (`IdActividad`) REFERENCES `actividades` (`IDActividad`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.pago_actividad: ~3 rows (aproximadamente)
INSERT INTO `pago_actividad` (`IdPagoActividad`, `IDCliente`, `IdActividad`, `FechaPago`, `ModoPago`, `Monto`, `Estado`) VALUES
	(1, 2, 1, '2025-06-06', 'Efectivo', 5000.00, 'Pagada'),
	(2, 2, 2, '2025-06-16', 'Efectivo', 5000.00, 'Pagada'),
	(3, 7, 4, '2025-06-16', 'Efectivo', 8000.00, 'Pagada');

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

-- Volcando estructura para tabla proyecto.socios
CREATE TABLE IF NOT EXISTS `socios` (
  `IDCliente` int(11) NOT NULL,
  `FechaAltaSocio` date NOT NULL,
  PRIMARY KEY (`IDCliente`),
  CONSTRAINT `fk_socio_cliente` FOREIGN KEY (`IDCliente`) REFERENCES `cliente` (`IDCliente`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.socios: ~4 rows (aproximadamente)
INSERT INTO `socios` (`IDCliente`, `FechaAltaSocio`) VALUES
	(1, '2025-05-10'),
	(3, '2025-05-15'),
	(6, '2025-06-16'),
	(8, '2025-06-16');

-- Volcando estructura para tabla proyecto.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `CodUsu` int(11) NOT NULL AUTO_INCREMENT,
  `NombreUsu` varchar(20) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `PassUsu` varchar(15) CHARACTER SET utf8 COLLATE utf8_bin DEFAULT NULL,
  `RolUsu` int(11) DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT 1,
  PRIMARY KEY (`CodUsu`),
  KEY `fk_usuario` (`RolUsu`),
  CONSTRAINT `fk_usuario` FOREIGN KEY (`RolUsu`) REFERENCES `roles` (`RolUsu`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Volcando datos para la tabla proyecto.usuario: ~3 rows (aproximadamente)
INSERT INTO `usuario` (`CodUsu`, `NombreUsu`, `PassUsu`, `RolUsu`, `Activo`) VALUES
	(1, 'Ana', '123456', 120, 1),
	(2, 'Juan', '123456', 120, 0),
	(3, 'Maria', '654321', 120, 1);

-- Volcando estructura para procedimiento proyecto.VerificarClienteID
DELIMITER //
CREATE PROCEDURE `VerificarClienteID`(
    IN p_ClienteID INT
)
BEGIN
-- Busco el id de cliente en la tabla cliente, devuelve el valor si existe
    SELECT IDCliente FROM cliente WHERE IDCliente = p_ClienteID;
END//
DELIMITER ;

-- Volcando estructura para procedimiento proyecto.VerificarClienteIDYBooleanSocio
DELIMITER //
CREATE PROCEDURE `VerificarClienteIDYBooleanSocio`(IN p_ClienteID INT)
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
END//
DELIMITER ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
