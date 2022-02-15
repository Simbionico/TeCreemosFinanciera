/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : MariaDB
 Source Server Version : 100413
 Source Host           : localhost:3306
 Source Schema         : tecreemos

 Target Server Type    : MariaDB
 Target Server Version : 100413
 File Encoding         : 65001

 Date: 15/02/2022 02:03:15
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for Cat006Cuentas
-- ----------------------------
DROP TABLE IF EXISTS `Cat006Cuentas`;
CREATE TABLE `Cat006Cuentas`  (
  `i_Cve_Cuenta` int(11) NOT NULL AUTO_INCREMENT,
  `t_NumeroCuenta` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `i_Saldo` float NULL DEFAULT NULL,
  `f_FechaRegistro` datetime NULL DEFAULT current_timestamp(),
  `i_Cve_Estatus` int(11) NULL DEFAULT NULL,
  `i_Cve_Estado` int(11) NULL DEFAULT 1,
  `i_Cve_Usuario` int(11) NULL DEFAULT NULL,
  `i_Cve_TipoCuenta` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`i_Cve_Cuenta`) USING BTREE,
  INDEX `fk_Cat006Cuentas_Cat000Usuarios`(`i_Cve_Usuario`) USING BTREE,
  CONSTRAINT `fk_Cat006Cuentas_Cat000Usuarios` FOREIGN KEY (`i_Cve_Usuario`) REFERENCES `cat000usuarios` (`i_Cve_Usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of Cat006Cuentas
-- ----------------------------
INSERT INTO `Cat006Cuentas` VALUES (1, '548450000000', 0, NULL, 1, 1, 1, 3);
INSERT INTO `Cat006Cuentas` VALUES (2, '783810000000', 0, '2022-02-15 00:54:32', 1, 1, 65, 2);
INSERT INTO `Cat006Cuentas` VALUES (3, '314620000000', 20, '2022-02-15 01:56:41', 1, 1, 68, 2);

-- ----------------------------
-- Table structure for cat000tipousuarios
-- ----------------------------
DROP TABLE IF EXISTS `cat000tipousuarios`;
CREATE TABLE `cat000tipousuarios`  (
  `i_Cve_TipoUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `t_TipoUsuario` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `t_DescripcionTipoUsuario` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `f_FechaRegistro` datetime NULL DEFAULT current_timestamp(),
  `i_Cve_Estatus` int(11) NULL DEFAULT NULL,
  `i_Cve_Estado` int(11) NULL DEFAULT 1,
  PRIMARY KEY (`i_Cve_TipoUsuario`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of cat000tipousuarios
-- ----------------------------
INSERT INTO `cat000tipousuarios` VALUES (1, 'Administrador', 'Administrador', '2022-02-12 23:08:57', 1, 1);
INSERT INTO `cat000tipousuarios` VALUES (2, 'Empleado', 'Empleado', '2022-02-12 23:08:57', 1, 1);
INSERT INTO `cat000tipousuarios` VALUES (5, 'Cliente', 'Cliente', '2022-02-12 23:08:57', 1, 1);

-- ----------------------------
-- Table structure for cat000usuarios
-- ----------------------------
DROP TABLE IF EXISTS `cat000usuarios`;
CREATE TABLE `cat000usuarios`  (
  `i_Cve_Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `t_Usuario` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `t_Contrasenia` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT '',
  `f_FechaRegistro` datetime NULL DEFAULT current_timestamp(),
  `i_Cve_Estatus` int(11) NULL DEFAULT NULL,
  `i_Cve_Estado` int(11) NULL DEFAULT 1,
  `i_Cve_TipoUsuario` int(11) NULL DEFAULT NULL,
  `i_Cve_Persona` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`i_Cve_Usuario`) USING BTREE,
  UNIQUE INDEX `i_Cve_Usuario_UNIQUE`(`i_Cve_Usuario`) USING BTREE,
  INDEX `fk_Cat000Usuarios_Cat000TipoUsuarios1_idx`(`i_Cve_TipoUsuario`) USING BTREE,
  INDEX `fk_Cat000Usuarios_Cat001Personas1_idx`(`i_Cve_Persona`) USING BTREE,
  CONSTRAINT `fk_Cat000Usuarios_Cat000TipoUsuarios1` FOREIGN KEY (`i_Cve_TipoUsuario`) REFERENCES `cat000tipousuarios` (`i_Cve_TipoUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Cat000Usuarios_Cat001Personas1` FOREIGN KEY (`i_Cve_Persona`) REFERENCES `cat002personas` (`i_Cve_Persona`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE = InnoDB AUTO_INCREMENT = 73 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of cat000usuarios
-- ----------------------------
INSERT INTO `cat000usuarios` VALUES (1, 'charlie.cs93@gmail.com', 'u2Xw6NcPO8Yq2Z5C0tqf7Q==', '2022-02-12 23:23:04', 1, 1, 1, 1);
INSERT INTO `cat000usuarios` VALUES (65, 'albert@gmail.com', '', '2022-02-13 19:16:39', 1, 1, 1, 17);
INSERT INTO `cat000usuarios` VALUES (66, 'otraPrueba@gmail.com', '', '2022-02-13 19:18:58', 0, 1, 2, 1);
INSERT INTO `cat000usuarios` VALUES (67, 'carlos@gmail.com', '', '2022-02-13 19:19:47', 1, 1, 5, 1);
INSERT INTO `cat000usuarios` VALUES (68, 'Nohely@gmail.com', '', '2022-02-13 19:26:31', 0, 1, 1, 1);
INSERT INTO `cat000usuarios` VALUES (69, 'Gary@gmail.com', '', '2022-02-13 19:27:23', 1, 1, 1, 16);
INSERT INTO `cat000usuarios` VALUES (70, 'Mildred@gmail.com', '', '2022-02-13 19:29:22', 1, 1, 1, 18);
INSERT INTO `cat000usuarios` VALUES (71, 'lau@hotmail.com', '', '2022-02-13 23:51:45', 0, 1, 5, 20);
INSERT INTO `cat000usuarios` VALUES (72, 'Laura2@gmail.com', '', '2022-02-15 01:50:05', 1, 1, 2, 20);

-- ----------------------------
-- Table structure for cat002generossexuales
-- ----------------------------
DROP TABLE IF EXISTS `cat002generossexuales`;
CREATE TABLE `cat002generossexuales`  (
  `i_Cve_GeneroSexual` int(11) NOT NULL AUTO_INCREMENT,
  `t_GeneroSexual` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `t_DescripcionGeneroSexual` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `f_FechaRegistro` datetime NULL DEFAULT current_timestamp(),
  `i_Cve_Estatus` int(11) NULL DEFAULT NULL,
  `i_Cve_Estado` int(11) NULL DEFAULT 1,
  PRIMARY KEY (`i_Cve_GeneroSexual`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 10 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of cat002generossexuales
-- ----------------------------
INSERT INTO `cat002generossexuales` VALUES (1, 'Masculino', 'Masculino', '2022-02-12 23:14:36', 1, 1);
INSERT INTO `cat002generossexuales` VALUES (2, 'Femenino', 'Femenino', '2022-02-12 23:14:36', 1, 1);

-- ----------------------------
-- Table structure for cat002personas
-- ----------------------------
DROP TABLE IF EXISTS `cat002personas`;
CREATE TABLE `cat002personas`  (
  `i_Cve_Persona` int(11) NOT NULL AUTO_INCREMENT,
  `t_Nombre` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `t_ApellidoPaterno` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `t_ApellidoMaterno` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `t_RFC` varchar(13) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `f_FechaNacimiento` date NULL DEFAULT NULL,
  `f_FechaRegistro` datetime NULL DEFAULT current_timestamp(),
  `i_Cve_Estatus` int(11) NULL DEFAULT NULL,
  `i_Cve_Estado` int(11) NULL DEFAULT 1,
  `i_Cve_GeneroSexual` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`i_Cve_Persona`) USING BTREE,
  INDEX `fk_Cat001Personas_Cat000GenerosSecuales1_idx`(`i_Cve_GeneroSexual`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 21 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of cat002personas
-- ----------------------------
INSERT INTO `cat002personas` VALUES (1, 'Carlos', 'Castellanos', '', '', '1993-02-27', '2022-02-12 23:12:49', 1, 1, 1);
INSERT INTO `cat002personas` VALUES (16, 'Gary', 'Ortiz', '', NULL, '2000-05-16', '2022-02-13 22:54:04', 1, 1, 1);
INSERT INTO `cat002personas` VALUES (17, 'Albert', 'Williamson', '', NULL, '1999-03-11', '2022-02-13 22:54:21', 1, 1, 1);
INSERT INTO `cat002personas` VALUES (18, 'Mildred', 'Fuller', '', NULL, '1984-02-15', '2022-02-13 22:55:18', 1, 1, 2);
INSERT INTO `cat002personas` VALUES (19, 'Russell', 'Robinson', '', NULL, '1988-10-31', '2022-02-13 22:56:20', 1, 1, 1);
INSERT INTO `cat002personas` VALUES (20, 'Laura', 'Harper', '', NULL, '2015-01-14', '2022-02-13 22:56:46', 1, 1, 2);

-- ----------------------------
-- Table structure for cat006TipoCuentas
-- ----------------------------
DROP TABLE IF EXISTS `cat006TipoCuentas`;
CREATE TABLE `cat006TipoCuentas`  (
  `i_Cve_TipoCuenta` int(11) NOT NULL AUTO_INCREMENT,
  `t_TipoCuenta` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `t_Descripcion` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `f_FechaRegistro` timestamp NULL DEFAULT current_timestamp(),
  `i_Cve_Estatus` int(11) NULL DEFAULT NULL,
  `i_Cve_Estado` int(11) NULL DEFAULT 1,
  PRIMARY KEY (`i_Cve_TipoCuenta`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of cat006TipoCuentas
-- ----------------------------
INSERT INTO `cat006TipoCuentas` VALUES (1, 'Credito', 'Cuenta de credito', '2022-02-14 20:19:39', 1, 1);
INSERT INTO `cat006TipoCuentas` VALUES (2, 'Debito', 'Cuenta de debito', '2022-02-14 20:19:51', 1, 1);
INSERT INTO `cat006TipoCuentas` VALUES (3, 'Ahorro', 'Cuenta de ahorro', '2022-02-14 20:20:01', 1, 1);

-- ----------------------------
-- Table structure for cat006tipostransaccion
-- ----------------------------
DROP TABLE IF EXISTS `cat006tipostransaccion`;
CREATE TABLE `cat006tipostransaccion`  (
  `i_Cve_TipoTransaccion` int(11) NOT NULL AUTO_INCREMENT,
  `t_TipoTransaccion` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `t_Descripcion` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `f_FechaRegistro` datetime NULL DEFAULT current_timestamp(),
  `i_Cve_Estatus` int(11) NULL DEFAULT NULL,
  `i_Cve_Estado` int(11) NULL DEFAULT 1,
  PRIMARY KEY (`i_Cve_TipoTransaccion`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of cat006tipostransaccion
-- ----------------------------
INSERT INTO `cat006tipostransaccion` VALUES (1, 'Depósito', 'Depósito', '2022-02-14 23:22:15', 1, 1);
INSERT INTO `cat006tipostransaccion` VALUES (2, 'Retiro', 'Retiro', '2022-02-14 23:22:36', 1, 1);

-- ----------------------------
-- Table structure for reg006transacciones
-- ----------------------------
DROP TABLE IF EXISTS `reg006transacciones`;
CREATE TABLE `reg006transacciones`  (
  `i_Cve_transaccion` int(11) NOT NULL AUTO_INCREMENT,
  `f_monto` float NULL DEFAULT NULL,
  `f_FechaRegistro` datetime NULL DEFAULT current_timestamp(),
  `i_Cve_Estatus` int(11) NULL DEFAULT NULL,
  `i_Cve_Estado` int(11) NULL DEFAULT 1,
  `i_Cve_Cuenta` int(11) NULL DEFAULT NULL,
  `i_Cve_TipoTransaccion` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`i_Cve_transaccion`) USING BTREE,
  INDEX `i_Cve_Cuenta`(`i_Cve_Cuenta`) USING BTREE,
  INDEX `i_Cve_TipoTransaccion`(`i_Cve_TipoTransaccion`) USING BTREE,
  CONSTRAINT `reg006transacciones_ibfk_1` FOREIGN KEY (`i_Cve_Cuenta`) REFERENCES `Cat006Cuentas` (`i_Cve_Cuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `reg006transacciones_ibfk_2` FOREIGN KEY (`i_Cve_TipoTransaccion`) REFERENCES `cat006tipostransaccion` (`i_Cve_TipoTransaccion`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE = InnoDB AUTO_INCREMENT = 17 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of reg006transacciones
-- ----------------------------
INSERT INTO `reg006transacciones` VALUES (11, 15, '2022-02-15 01:53:33', NULL, 1, 1, 2);
INSERT INTO `reg006transacciones` VALUES (12, 2, '2022-02-15 01:54:02', NULL, 1, 1, 1);
INSERT INTO `reg006transacciones` VALUES (13, 5, '2022-02-15 01:54:21', NULL, 1, 1, 2);
INSERT INTO `reg006transacciones` VALUES (14, 100, '2022-02-15 01:57:38', NULL, 1, 3, 1);
INSERT INTO `reg006transacciones` VALUES (15, 75, '2022-02-15 01:58:16', NULL, 1, 3, 2);
INSERT INTO `reg006transacciones` VALUES (16, 5, '2022-02-15 02:01:00', NULL, 1, 3, 2);

-- ----------------------------
-- View structure for vt000usuarios
-- ----------------------------
DROP VIEW IF EXISTS `vt000usuarios`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `vt000usuarios` AS SELECT
	usu.i_Cve_Usuario AS i_Cve_Usuario,
	usu.t_Usuario AS t_Usuario,
	usu.t_Contrasenia AS t_Contrasenia,
	usu.f_FechaRegistro AS f_FechaRegistro,
	usu.i_Cve_TipoUsuario AS i_Cve_TipoUsuario,
	tip.t_TipoUsuario AS t_TipoUsuario,
	usu.i_Cve_Persona AS i_Cve_Persona,
	concat( per.t_Nombre, ' ', per.t_ApellidoPaterno, ' ', per.t_ApellidoMaterno ) AS t_NombreUsuario,
	concat( per.t_Nombre, ' ', per.t_ApellidoPaterno, ' ', per.t_ApellidoMaterno, '/' ,usu.t_Usuario ) AS t_NombreUsuarioCompleto,
	usu.i_Cve_Estatus AS i_Cve_Estatus,
	CASE WHEN usu.i_Cve_Estatus = 1 THEN 'Habilitado'  WHEN usu.i_Cve_Estatus = 2 THEN 'Pendiente' ELSE 'Deshabilitado'  END AS t_Estatus,
	usu.i_Cve_Estado AS i_Cve_Estado 
FROM
	cat000usuarios usu 
	inner join cat000tipousuarios tip ON  tip.i_Cve_TipoUsuario = usu.i_Cve_TipoUsuario 
	inner join cat002personas per ON per.i_Cve_Persona = usu.i_Cve_Persona 
WHERE
	usu.i_Cve_Estado = 1 
	AND tip.i_Cve_Estado = 1 
	AND per.i_Cve_Estado = 1 ;

-- ----------------------------
-- View structure for vt006cuentas
-- ----------------------------
DROP VIEW IF EXISTS `vt006cuentas`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `vt006cuentas` AS SELECT
	cue.i_Cve_Cuenta,
	cue.t_NumeroCuenta,
	cue.i_Saldo,
	cue.f_FechaRegistro,
	cue.i_Cve_Usuario,
	usu.t_Usuario,
	cue.i_Cve_TipoCuenta,
	tcu.t_TipoCuenta,
	CASE WHEN cue.i_Cve_Estatus = 1 THEN 'Activa' ELSE 'Deshabilitado' END AS t_Estatus
FROM
	Cat006Cuentas AS cue
	INNER JOIN cat006TipoCuentas AS tcu on tcu.i_Cve_TipoCuenta = cue.i_Cve_TipoCuenta
	INNER JOIN cat000usuarios AS usu ON usu.i_Cve_Usuario = cue.i_Cve_Usuario
WHERE
	cue.i_Cve_Estado = 1
	AND tcu.i_Cve_Estado = 1
	AND usu.i_Cve_Estado = 1 ;

-- ----------------------------
-- View structure for vt006transacciones
-- ----------------------------
DROP VIEW IF EXISTS `vt006transacciones`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `vt006transacciones` AS SELECT
	tra.i_Cve_transaccion,
	tra.f_monto,
	tra.f_FechaRegistro,
	tra.i_Cve_Cuenta,
	cue.t_NumeroCuenta,
	tra.i_Cve_TipoTransaccion,
	tta.t_TipoTransaccion,
	cue.i_Cve_Usuario,
	usu.t_Usuario
FROM
	reg006transacciones AS tra
	INNER JOIN Cat006Cuentas AS cue ON cue.i_Cve_Cuenta = tra.i_Cve_Cuenta
	INNER JOIN cat006tipostransaccion AS tta ON tta.i_Cve_TipoTransaccion = tra.i_Cve_TipoTransaccion
	INNER JOIN cat000usuarios AS usu ON usu.i_Cve_Usuario = cue.i_Cve_Usuario
WHERE
	tra.i_Cve_Estado = 1
	AND cue.i_Cve_Estado = 1
	AND tta.i_Cve_Estado = 1 ;

SET FOREIGN_KEY_CHECKS = 1;
