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
) ENGINE=InnoDB AUTO_INCREMENT=192 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `otros_resultados` */

insert  into `otros_resultados`(`id`,`PrimerTermino`,`ReynoldEnjambre`,`SegundoTermino`,`TercerTermino`,`FuncionObjetivo`,`DiametroBurbuja`,`resultado_id`) values 
(112,0.000000153235277,0.999999999999999,0.999999999999999,0.999999999999999,-0.000325527157757,0.000615379455841,68),
(113,0.000000153235277,0.999999999999999,0.999999999999999,0.999999999999999,-0.000007637321412,0.000605850728945,68),
(114,0.000000153235277,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000007581619,0.000605841250828,68),
(115,0.000000153235277,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000008,0.000605841250818,68),
(116,0.000000142204928,0.999999999999999,0.999999999999999,0.999999999999999,-0.000374874278157,0.000565820956375,69),
(117,0.000000142204928,0.999999999999999,0.999999999999999,0.999999999999999,-0.000008776263849,0.000555076353541,69),
(118,0.000000142204928,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000009409679,0.000555064808595,69),
(119,0.000000142204928,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000011,0.000555064808581,69),
(120,0.000000143290704,0.999999999999999,0.999999999999999,0.999999999999999,-0.000371447541608,0.000569286099345,70),
(121,0.000000143290704,0.999999999999999,0.999999999999999,0.999999999999999,-0.000008687245683,0.000558639564745,70),
(122,0.000000143290704,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000009238097,0.000558628218885,70),
(123,0.000000143290704,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000011,0.000558628218872,70),
(124,0.000000142566853,0.999999999999999,0.999999999999999,0.999999999999999,-0.000373731437611,0.000566975754874,71),
(125,0.000000142566853,0.999999999999999,0.999999999999999,0.999999999999999,-0.000008746685211,0.000556263695455,71),
(126,0.000000142566853,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000009352598,0.000556252216679,71),
(127,0.000000142566853,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000011,0.000556252216665,71),
(128,0.000000182689397,0.999999999999999,0.999999999999999,0.999999999999999,-0.000317999988202,0.000629261484995,72),
(129,0.000000182689397,0.999999999999999,0.999999999999999,0.999999999999999,-0.000006249805842,0.000621639609411,72),
(130,0.000000182689397,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000004134757,0.000621634560218,72),
(131,0.000000182689397,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000002,0.000621634560215,72),
(132,0.000000189094189,0.999999999999999,0.999999999999999,0.999999999999999,-0.000317952506255,0.000630695868401,73),
(133,0.000000189094189,0.999999999999999,0.999999999999999,0.999999999999999,-0.000005995328069,0.000623425494292,73),
(134,0.000000189094189,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000003620561,0.000623421098411,73),
(135,0.000000189094189,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000001,0.000623421098410,73),
(136,0.000000191838402,0.999999999999999,0.999999999999999,0.999999999999999,-0.000319419992594,0.000629891753073,74),
(137,0.000000191838402,0.999999999999999,0.999999999999999,0.999999999999999,-0.000005900158366,0.000622760557658,74),
(138,0.000000191838402,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000003413074,0.000622756427673,74),
(139,0.000000191838402,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000001,0.000622756427672,74),
(140,0.000000201475055,0.999999999999999,0.999999999999999,0.999999999999999,-0.000321596953418,0.000629915569214,75),
(141,0.000000201475055,0.999999999999999,0.999999999999999,0.999999999999999,-0.000005545028302,0.000623278691925,75),
(142,0.000000201475055,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000002768225,0.000623275375301,75),
(143,0.000000201475055,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000001,0.000623275375301,75),
(144,0.000000232529500,0.999999999999999,0.999999999999999,0.999999999999999,-0.000210148152619,0.000746751798355,76),
(145,0.000000232529500,0.999999999999999,0.999999999999999,0.999999999999999,-0.000003293470239,0.000742644640697,76),
(146,0.000000232529500,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000001148610,0.000742643207310,76),
(147,0.000000232529500,0.999999999999999,0.999999999999999,0.999999999999999,0.000000000000000,0.000742643207310,76),
(148,0.000000238127307,0.999999999999999,0.999999999999999,0.999999999999999,-0.000217301424497,0.000739960912439,77),
(149,0.000000238127307,0.999999999999999,0.999999999999999,0.999999999999999,-0.000003328943842,0.000735841490033,77),
(150,0.000000238127307,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000001115715,0.000735840108457,77),
(151,0.000000238127307,0.999999999999999,0.999999999999999,0.999999999999999,0.000000000000000,0.000735840108457,77),
(152,0.000000245791707,0.999999999999999,0.999999999999999,0.999999999999999,-0.000210022404023,0.000748632236604,78),
(153,0.000000245791707,0.999999999999999,0.999999999999999,0.999999999999999,-0.000003086245082,0.000744818222073,78),
(154,0.000000245791707,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000937681,0.000744817062571,78),
(155,0.000000245791707,0.999999999999999,0.999999999999999,0.999999999999999,0.000000000000000,0.000744817062571,78),
(156,0.000000252974238,0.999999999999999,0.999999999999999,0.999999999999999,-0.000215117824807,0.000744244084691,79),
(157,0.000000252974238,0.999999999999999,0.999999999999999,0.999999999999999,-0.000003057475800,0.000740494604883,79),
(158,0.000000252974238,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000870668,0.000740493536547,79),
(159,0.000000252974238,0.999999999999999,0.999999999999999,0.999999999999999,0.000000000000000,0.000740493536546,79),
(160,0.000000283874867,0.999999999999999,0.999999999999999,0.999999999999999,-0.000112535380357,0.000860210027563,80),
(161,0.000000283874867,0.999999999999999,0.999999999999999,0.999999999999999,-0.000001088586011,0.000858830114619,80),
(162,0.000000283874867,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000122625,0.000858829959142,80),
(163,0.000000294295427,0.999999999999999,0.999999999999999,0.999999999999999,-0.000114197781087,0.000858988975342,81),
(164,0.000000294295427,0.999999999999999,0.999999999999999,0.999999999999999,-0.000001070392887,0.000857641049259,81),
(165,0.000000294295427,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000113130,0.000857640906766,81),
(166,0.000000301848020,0.999999999999999,0.999999999999999,0.999999999999999,-0.000110646862326,0.000863582795782,82),
(167,0.000000301848020,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000988436038,0.000862341169906,82),
(168,0.000000301848020,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000094192,0.000862341051564,82),
(169,0.000000306905670,0.999999999999999,0.999999999999999,0.999999999999999,-0.000112787976404,0.000861451183249,83),
(170,0.000000306905670,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000998991689,0.000860201072868,83),
(171,0.000000306905670,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000093738,0.000860200955545,83),
(172,0.000000333674334,0.999999999999999,0.999999999999999,0.999999999999999,-0.000016536977905,0.000978764030319,84),
(173,0.000000333674334,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000027119577,0.000978729089505,84),
(174,0.000000333674334,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000075,0.000978729089409,84),
(175,0.000000346432317,0.999999999999999,0.999999999999999,0.999999999999999,-0.000018420323893,0.000976506487691,85),
(176,0.000000346432317,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000032123876,0.000976465372274,85),
(177,0.000000346432317,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000101,0.000976465372145,85),
(178,0.000000356356320,0.999999999999999,0.999999999999999,0.999999999999999,-0.000012961896845,0.000983487362439,86),
(179,0.000000356356320,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000015686094,0.000983467330669,86),
(180,0.000000356356320,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000023,0.000983467330639,86),
(181,0.000000362851255,0.999999999999999,0.999999999999999,0.999999999999999,-0.000014922400953,0.000981066627387,87),
(182,0.000000362851255,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000020232767,0.000981040886161,87),
(183,0.000000362851255,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000038,0.000981040886113,87),
(184,0.000000182818948,0.999999999999999,0.999999999999999,0.999999999999999,-0.000205829784666,0.000744715681415,88),
(185,0.000000182818948,0.999999999999999,0.999999999999999,0.999999999999999,-0.000004037416276,0.000739487295894,88),
(186,0.000000182818948,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000002273758,0.000739484348090,88),
(187,0.000000182818948,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000001,0.000739484348089,88),
(188,0.000000151030055,0.999999999999999,0.999999999999999,0.999999999999999,-0.000332601634620,0.000608003707149,89),
(189,0.000000151030055,0.999999999999999,0.999999999999999,0.999999999999999,-0.000007849854557,0.000598229377466,89),
(190,0.000000151030055,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000007987405,0.000598219411506,89),
(191,0.000000151030055,0.999999999999999,0.999999999999999,0.999999999999999,-0.000000000000008,0.000598219411495,89);

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
) ENGINE=InnoDB AUTO_INCREMENT=90 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

/*Data for the table `resultados` */

insert  into `resultados`(`id`,`deltap`,`jsl`,`holdup`,`db`,`ub`,`reb`,`usg`,`jg`,`concentracion_id`,`espumante_id`) values 
(68,0.62,0.78,14.87,0.61,6.57,36.11,0.05,0.68,5,4),
(69,0.60,0.75,17.62,0.56,5.96,30.05,0.05,0.68,6,4),
(70,0.60,0.78,17.62,0.56,6.01,30.46,0.05,0.68,7,4),
(71,0.60,0.76,17.62,0.56,5.98,30.19,0.05,0.68,8,4),
(72,0.52,0.74,28.60,0.62,6.75,38.10,0.05,1.02,5,4),
(73,0.50,0.79,31.35,0.62,6.77,38.33,0.04,1.02,6,4),
(74,0.49,0.79,32.72,0.62,6.76,38.24,0.04,1.02,7,4),
(75,0.46,0.76,36.84,0.62,6.77,38.31,0.04,1.02,8,4),
(76,0.50,0.74,31.35,0.74,8.14,54.87,0.05,1.36,5,4),
(77,0.48,0.74,34.10,0.74,8.06,53.85,0.05,1.36,6,4),
(78,0.47,0.79,35.47,0.74,8.16,55.19,0.05,1.36,7,4),
(79,0.45,0.75,38.22,0.74,8.11,54.55,0.05,1.36,8,4),
(80,0.48,0.73,34.10,0.86,9.42,73.44,0.06,1.70,5,4),
(81,0.46,0.75,36.84,0.86,9.41,73.23,0.06,1.70,6,4),
(82,0.45,0.77,38.22,0.86,9.46,74.03,0.06,1.70,7,4),
(83,0.44,0.75,39.59,0.86,9.43,73.67,0.06,1.70,8,4),
(84,0.47,0.72,35.47,0.98,10.69,95.03,0.07,2.04,5,4),
(85,0.45,0.74,38.22,0.98,10.67,94.60,0.07,2.04,6,4),
(86,0.44,0.77,39.59,0.98,10.74,95.93,0.06,2.04,7,4),
(87,0.43,0.75,40.96,0.98,10.72,95.47,0.06,2.04,8,4),
(88,0.65,0.78,10.76,0.74,8.10,54.40,0.07,0.68,5,4),
(89,0.62,0.77,14.87,0.60,6.48,35.17,0.05,0.67,5,4);

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
