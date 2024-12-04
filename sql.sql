/*
SQLyog Community v13.3.0 (64 bit)
MySQL - 10.4.32-MariaDB : Database - caidapresion
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`caidapresion` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `caidapresion`;

/*Table structure for table `concentracion` */

DROP TABLE IF EXISTS `concentracion`;

CREATE TABLE `concentracion` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(10) NOT NULL,
  `alias` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `concentracion` */

insert  into `concentracion`(`id`,`nombre`,`alias`) values 
(5,'20ppm',20),
(6,'50ppm',50),
(7,'75ppm',75),
(8,'100ppm',100);

/*Table structure for table `espumante` */

DROP TABLE IF EXISTS `espumante`;

CREATE TABLE `espumante` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(10) NOT NULL,
  `descripcion` longtext DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `espumante` */

insert  into `espumante`(`id`,`nombre`,`descripcion`) values 
(4,'MIBC',''),
(5,'AF65',NULL),
(6,'LESS',NULL);

/*Table structure for table `espumante_concentracion` */

DROP TABLE IF EXISTS `espumante_concentracion`;

CREATE TABLE `espumante_concentracion` (
  `espumante_id` int(11) NOT NULL,
  `concentracion_id` int(11) NOT NULL,
  KEY `centracion_id` (`concentracion_id`),
  KEY `espumante_concentracion_ibfk_1` (`espumante_id`),
  CONSTRAINT `espumante_concentracion_ibfk_1` FOREIGN KEY (`espumante_id`) REFERENCES `espumante` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `espumante_concentracion_ibfk_2` FOREIGN KEY (`concentracion_id`) REFERENCES `concentracion` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `espumante_concentracion` */

insert  into `espumante_concentracion`(`espumante_id`,`concentracion_id`) values 
(4,5),
(4,6),
(4,7),
(4,8),
(5,5),
(5,6),
(5,7),
(5,8),
(6,5),
(6,6),
(6,7),
(6,8);

/*Table structure for table `grafica` */

DROP TABLE IF EXISTS `grafica`;

CREATE TABLE `grafica` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `grafica` */

insert  into `grafica`(`id`,`nombre`) values 
(1,'AirHoldup Vs Jg'),
(2,'Usg Vs Air holdup'),
(3,'Diámetro de burbuja Vs Jg'),
(4,'Diámetro de burbuja Vs concentración');

/*Table structure for table `otros_resultados` */

DROP TABLE IF EXISTS `otros_resultados`;

CREATE TABLE `otros_resultados` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `PrimerTermino` decimal(15,15) NOT NULL,
  `ReynoldEnjambre` decimal(15,15) NOT NULL,
  `SegundoTermino` decimal(15,15) NOT NULL,
  `TercerTermino` decimal(15,15) NOT NULL,
  `FuncionObjetivo` decimal(15,15) NOT NULL,
  `DiametroBurbuja` decimal(15,15) NOT NULL,
  `resultado_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `resultado_id` (`resultado_id`),
  CONSTRAINT `otros_resultados_ibfk_1` FOREIGN KEY (`resultado_id`) REFERENCES `resultados` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `otros_resultados` */

insert  into `otros_resultados`(`id`,`PrimerTermino`,`ReynoldEnjambre`,`SegundoTermino`,`TercerTermino`,`FuncionObjetivo`,`DiametroBurbuja`,`resultado_id`) values 
(41,0.000000158712082,0.999999999999999,0.999999999999999,0.999999999999999,-0.000300332786306,0.000641429498567,50),
(42,0.000000158712082,0.999999999999999,0.999999999999999,0.999999999999999,-0.000006959171638,0.000632666864821,50),
(43,0.000000158712082,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000006460511,0.000632658714895,50),
(44,0.000000158712082,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000006,0.000632658714887,50),
(45,0.000000152907259,0.999999999999999,0.999999999999999,0.999999999999999,-0.000326578162542,0.000614281447062,51),
(46,0.000000152907259,0.999999999999999,0.999999999999999,0.999999999999999,-0.000007669061426,0.000604715949893,51),
(47,0.000000152907259,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000007641713,0.000604706399404,51),
(48,0.000000152907259,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000008,0.000604706399394,51),
(49,0.000000147934756,0.999999999999999,0.999999999999999,0.999999999999999,-0.000349731285080,0.000590851431032,52),
(50,0.000000147934756,0.999999999999999,0.999999999999999,0.999999999999999,-0.000008228010128,0.000580679562021,52),
(51,0.000000147934756,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000008548406,0.000580668971969,52),
(52,0.000000147934756,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000009,0.000580668971958,52),
(53,0.000000142566853,0.999999999999999,0.999999999999999,0.999999999999999,-0.000373731437611,0.000566975754874,53),
(54,0.000000142566853,0.999999999999999,0.999999999999999,0.999999999999999,-0.000008746685211,0.000556263695455,53),
(55,0.000000142566853,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000009352598,0.000556252216679,53),
(56,0.000000142566853,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000011,0.000556252216665,53),
(57,0.000000182429270,0.999999999999999,0.999999999999999,0.999999999999999,-0.000302162999250,0.000644552220588,54),
(58,0.000000182429270,0.999999999999999,0.999999999999999,0.999999999999999,-0.000006074801785,0.000637071016622,54),
(59,0.000000182429270,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000004125823,0.000637065928683,54),
(60,0.000000182429270,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000002,0.000637065928681,54),
(61,0.000000183033331,0.999999999999999,0.999999999999999,0.999999999999999,-0.000308834386033,0.000638176450753,55),
(62,0.000000183033331,0.999999999999999,0.999999999999999,0.999999999999999,-0.000006136478129,0.000630653271932,55),
(63,0.000000183033331,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000004101856,0.000630648236403,55),
(64,0.000000183033331,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000002,0.000630648236400,55),
(65,0.000000183245382,0.999999999999999,0.999999999999999,0.999999999999999,-0.000316529763602,0.000630793235797,56),
(66,0.000000183245382,0.999999999999999,0.999999999999999,0.999999999999999,-0.000006212835243,0.000623213365008,56),
(67,0.000000183245382,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000004089416,0.000623208369186,56),
(68,0.000000183245382,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000002,0.000623208369184,56),
(69,0.000000184022938,0.999999999999999,0.999999999999999,0.999999999999999,-0.000322705802422,0.000625056926348,57),
(70,0.000000184022938,0.999999999999999,0.999999999999999,0.999999999999999,-0.000006238992123,0.000617479382185,57),
(71,0.000000184022938,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000004009513,0.000617474506162,57),
(72,0.000000184022938,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000002,0.000617474506160,57);

/*Table structure for table `resultados` */

DROP TABLE IF EXISTS `resultados`;

CREATE TABLE `resultados` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `deltap` decimal(10,2) NOT NULL,
  `jsl` decimal(10,2) NOT NULL,
  `holdup` decimal(10,2) NOT NULL,
  `db` decimal(10,2) NOT NULL,
  `ub` decimal(10,2) NOT NULL,
  `reb` decimal(10,2) NOT NULL,
  `usg` decimal(10,2) NOT NULL,
  `jg` decimal(10,2) NOT NULL,
  `concentracion_id` int(11) NOT NULL,
  `espumante_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `resultados_ibfk_1` (`concentracion_id`),
  KEY `espumante_id` (`espumante_id`),
  CONSTRAINT `resultados_ibfk_1` FOREIGN KEY (`concentracion_id`) REFERENCES `concentracion` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `resultados_ibfk_2` FOREIGN KEY (`espumante_id`) REFERENCES `espumante` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `resultados` */

insert  into `resultados`(`id`,`deltap`,`jsl`,`holdup`,`db`,`ub`,`reb`,`usg`,`jg`,`concentracion_id`,`espumante_id`) values 
(50,0.63,0.72,13.50,0.63,6.88,39.52,0.06,0.68,5,5),
(51,0.62,0.77,14.87,0.60,6.55,35.97,0.05,0.68,6,5),
(52,0.61,0.79,16.25,0.58,6.27,33.05,0.05,0.68,7,5),
(53,0.60,0.76,17.62,0.56,5.98,30.19,0.05,0.68,8,5),
(54,0.54,0.75,25.86,0.64,6.93,40.09,0.05,1.02,5,5),
(55,0.53,0.76,27.23,0.63,6.86,39.26,0.05,1.02,6,5),
(56,0.52,0.75,28.60,0.62,6.77,38.30,0.05,1.02,7,5),
(57,0.51,0.74,29.98,0.62,6.70,37.57,0.04,1.02,8,5);

/* Procedure structure for procedure `Actualizar_espumante` */

/*!50003 DROP PROCEDURE IF EXISTS  `Actualizar_espumante` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `Actualizar_espumante`(
    IN _nombre VARCHAR(10),IN _descripcion LONGTEXT,in _id INT(11)
    )
BEGIN
	update `espumante` set `nombre`=_nombre,`descripcion`=_descripcion where id=_id;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `Insertar_espumante` */

/*!50003 DROP PROCEDURE IF EXISTS  `Insertar_espumante` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `Insertar_espumante`(
    in _nombre varchar(10),in _descripcion longtext,out _id_espumante int(11)  )
BEGIN
		insert into `espumante` (`nombre`,`descripcion`)values(_nombre,_descripcion);
		SELECT MAX(id) INTO _id_espumante FROM espumante;
	END */$$
DELIMITER ;

/* Procedure structure for procedure `insertar_espumante_concentracion` */

/*!50003 DROP PROCEDURE IF EXISTS  `insertar_espumante_concentracion` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_espumante_concentracion`(in _espumante_id int(11),in _concentracion_id int(11))
BEGIN
insert into `espumante_concentracion`(`espumante_id`,`concentracion_id`)values(_espumante_id,_concentracion_id);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `insertar_otros_resultados` */

/*!50003 DROP PROCEDURE IF EXISTS  `insertar_otros_resultados` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_otros_resultados`(
    in _PrimerTermino decimal(15,15),
    in _ReynoldEnjambre DECIMAL(15,15),
    in _SegundoTermino DECIMAL(15,15),
    in _TercerTermino DECIMAL(15,15),
    in _FuncionObjetivo DECIMAL(15,15),
    in _DiametroBurbuja DECIMAL(15,15),
    in _resultado_id int(11))
BEGIN
		INSERT INTO `otros_resultados`
		(PrimerTermino,ReynoldEnjambre,SegundoTermino,TercerTermino,FuncionObjetivo,DiametroBurbuja,resultado_id)
		VALUES 
		( _PrimerTermino,_ReynoldEnjambre,_SegundoTermino,_TercerTermino,_FuncionObjetivo,_DiametroBurbuja,_resultado_id);
	END */$$
DELIMITER ;

/* Procedure structure for procedure `insertar_resultados` */

/*!50003 DROP PROCEDURE IF EXISTS  `insertar_resultados` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_resultados`(
IN _deltap DECIMAL(10,2),
					IN _jsl DECIMAL(10,5),
					IN _holdup DECIMAL(10,5),
					IN _db DECIMAL(10,5), 
					IN _ub DECIMAL(10,5),
					IN _reb DECIMAL(10,5),
					IN _usg DECIMAL(10,5),
					IN _jg DECIMAL(10,5),
					IN _concentracion_id INT(11),
					IN _espumante_id INT (11),
					OUT _id_resultado int(11)   
    )
BEGIN
INSERT INTO `resultados`(`deltap`,`jsl`,`holdup`,`db`,`ub`,`reb`,`usg`,`jg`,`concentracion_id`,`espumante_id`)VALUES(_deltap,_jsl,_holdup,_db,_ub,_reb,_usg,_jg,_concentracion_id,_espumante_id);
select max(id) into _id_resultado from resultados;
END */$$
DELIMITER ;

/*Table structure for table `view_espumante_concentracion` */

DROP TABLE IF EXISTS `view_espumante_concentracion`;

/*!50001 DROP VIEW IF EXISTS `view_espumante_concentracion` */;
/*!50001 DROP TABLE IF EXISTS `view_espumante_concentracion` */;

/*!50001 CREATE TABLE  `view_espumante_concentracion`(
 `espumante_id` int(11) ,
 `espumante` varchar(10) ,
 `concentracion_id` int(11) ,
 `concentracion` varchar(10) 
)*/;

/*Table structure for table `view_resultados` */

DROP TABLE IF EXISTS `view_resultados`;

/*!50001 DROP VIEW IF EXISTS `view_resultados` */;
/*!50001 DROP TABLE IF EXISTS `view_resultados` */;

/*!50001 CREATE TABLE  `view_resultados`(
 `id` int(11) ,
 `Jg(cm/s)` decimal(10,2) ,
 `DeltaP(Psi)` decimal(10,2) ,
 `Jsl(cm/s)` decimal(10,2) ,
 `%Holdup` decimal(10,2) ,
 `Db(mm)` decimal(10,2) ,
 `Ub(cm/s)` decimal(10,2) ,
 `Usg(m/s)` decimal(10,2) ,
 `Reynold de burbuja` decimal(10,2) ,
 `concentracion_id` int(11) ,
 `Concentración(ppm)` int(11) ,
 `espumante_id` int(11) ,
 `espumante` varchar(10) 
)*/;

/*View structure for view view_espumante_concentracion */

/*!50001 DROP TABLE IF EXISTS `view_espumante_concentracion` */;
/*!50001 DROP VIEW IF EXISTS `view_espumante_concentracion` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_espumante_concentracion` AS select `esp`.`id` AS `espumante_id`,`esp`.`nombre` AS `espumante`,`conc`.`id` AS `concentracion_id`,`conc`.`nombre` AS `concentracion` from ((`espumante` `esp` join `espumante_concentracion` `pivote` on(`esp`.`id` = `pivote`.`espumante_id`)) join `concentracion` `conc` on(`conc`.`id` = `pivote`.`concentracion_id`)) */;

/*View structure for view view_resultados */

/*!50001 DROP TABLE IF EXISTS `view_resultados` */;
/*!50001 DROP VIEW IF EXISTS `view_resultados` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_resultados` AS select `resultados`.`id` AS `id`,`resultados`.`jg` AS `Jg(cm/s)`,`resultados`.`deltap` AS `DeltaP(Psi)`,`resultados`.`jsl` AS `Jsl(cm/s)`,`resultados`.`holdup` AS `%Holdup`,`resultados`.`db` AS `Db(mm)`,`resultados`.`ub` AS `Ub(cm/s)`,`resultados`.`usg` AS `Usg(m/s)`,`resultados`.`reb` AS `Reynold de burbuja`,`concentracion`.`id` AS `concentracion_id`,`concentracion`.`alias` AS `Concentración(ppm)`,`espumante`.`id` AS `espumante_id`,`espumante`.`nombre` AS `espumante` from ((`resultados` join `espumante` on(`espumante`.`id` = `resultados`.`espumante_id`)) join `concentracion` on(`concentracion`.`id` = `resultados`.`concentracion_id`)) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
