-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.73-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema masivian
--

CREATE DATABASE IF NOT EXISTS masivian;
USE masivian;

--
-- Definition of table `bet_roulette`
--

DROP TABLE IF EXISTS `bet_roulette`;
CREATE TABLE `bet_roulette` (
  `id` varchar(45) NOT NULL,
  `id_roulette` varchar(45) NOT NULL,
  `id_user` varchar(45) NOT NULL,
  `number` int(11) DEFAULT NULL,
  `id_color` varchar(45) DEFAULT NULL,
  `money` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bet_roulette`
--

/*!40000 ALTER TABLE `bet_roulette` DISABLE KEYS */;
INSERT INTO `bet_roulette` (`id`,`id_roulette`,`id_user`,`number`,`id_color`,`money`) VALUES 
 ('1044c6c7-bbc3-4dc5-ae1a-d318a1e2db5f','aa21b7bc-c6be-403e-8538-e2a2f4757d35','ANDRES',29,NULL,365),
 ('1a1a5204-c221-4ccf-a919-4096bcdb24dc','aa21b7bc-c6be-403e-8538-e2a2f4757d35','NELIS',34,NULL,12),
 ('1bc94815-90c5-4231-a7ed-5eb053f5e5db','aa21b7bc-c6be-403e-8538-e2a2f4757d35','10361',21,NULL,70),
 ('2245e030-96c5-45b7-b351-395cfae98050','aa21b7bc-c6be-403e-8538-e2a2f4757d35','8',1,NULL,19),
 ('24dbf4b4-d2e4-43b6-b8ca-4b5eebf3f691','aa21b7bc-c6be-403e-8538-e2a2f4757d35','JJ',35,NULL,122),
 ('25dc780d-7c9f-46b8-ac55-e79c6a334b43','aa21b7bc-c6be-403e-8538-e2a2f4757d35','77WER',15,NULL,10),
 ('311fdeae-93a7-4b28-8f32-97070e9ac961','aa21b7bc-c6be-403e-8538-e2a2f4757d35','77WERRCFR',17,NULL,200),
 ('321712d9-232f-48cd-82a1-7d2396541484','aa21b7bc-c6be-403e-8538-e2a2f4757d35','FELI',31,NULL,365),
 ('34d8c5de-3989-4bfc-b2c6-5330894b31e2','aa21b7bc-c6be-403e-8538-e2a2f4757d35','10361',19,NULL,70),
 ('3523fe77-90fb-4cc4-b1f5-bcfa4875f200','aa21b7bc-c6be-403e-8538-e2a2f4757d35','9',2,NULL,22),
 ('3ba7d1d8-951d-4d20-a336-42cea5951b3b','aa21b7bc-c6be-403e-8538-e2a2f4757d35','1036',18,NULL,77),
 ('473a41e7-ce33-40c3-ba28-533270e30251','aa21b7bc-c6be-403e-8538-e2a2f4757d35','ANDRES',30,NULL,365),
 ('4a40067b-375a-42c5-8832-b8c5d9fcad5c','aa21b7bc-c6be-403e-8538-e2a2f4757d35','99',5,NULL,89),
 ('5558d971-5f95-421c-b4e7-b313bb1ff263','aa21b7bc-c6be-403e-8538-e2a2f4757d35','10',8,NULL,2),
 ('58831b4a-ad8a-44aa-9d66-b4348ecf7500','aa21b7bc-c6be-403e-8538-e2a2f4757d35','7',0,NULL,16),
 ('5ea52c33-f5b0-4d53-a862-2400b1d6cdcd','aa21b7bc-c6be-403e-8538-e2a2f4757d35','555',11,NULL,234),
 ('603835b4-92aa-40f9-b4ac-990da803adca','aa21b7bc-c6be-403e-8538-e2a2f4757d35','10361',22,NULL,70),
 ('67c01ca9-aa6e-4750-a253-44077f46cbb4','aa21b7bc-c6be-403e-8538-e2a2f4757d35','92',3,NULL,89),
 ('6bfb6369-3d0c-4d57-8863-ce62aa86520e','aa21b7bc-c6be-403e-8538-e2a2f4757d35','FREDY',27,NULL,1450),
 ('6d775079-cae7-479a-93c6-d3fbf236bf04','aa21b7bc-c6be-403e-8538-e2a2f4757d35','78',6,NULL,200),
 ('72d5da8c-eeab-4159-b8f1-20410d808765','aa21b7bc-c6be-403e-8538-e2a2f4757d35','10361WEXSD',25,NULL,236),
 ('8296632d-9958-409a-8512-22980484148e','aa21b7bc-c6be-403e-8538-e2a2f4757d35','10361',20,NULL,70),
 ('93d299fb-b084-4ca1-be4f-1448ad7ff1e2','aa21b7bc-c6be-403e-8538-e2a2f4757d35','FREDY',36,NULL,44),
 ('99ebd27a-9781-4d6b-a1a6-1fae26cb1fae','aa21b7bc-c6be-403e-8538-e2a2f4757d35','91',4,NULL,145),
 ('aba4c1e4-5132-4e4c-bcb9-37792624fb19','aa21b7bc-c6be-403e-8538-e2a2f4757d35','77FX',13,NULL,10),
 ('b00dcb37-1736-4c63-bae4-bc9b20265e35','aa21b7bc-c6be-403e-8538-e2a2f4757d35','77WERRCF',16,NULL,200),
 ('b28fc8e1-89b6-46bf-a995-960d48108453','aa21b7bc-c6be-403e-8538-e2a2f4757d35','MOM',NULL,'dfa10417-3741-11eb-9298-6302df5b2bc2',63),
 ('b97dad34-4091-4a9b-b895-c3510565e5bf','aa21b7bc-c6be-403e-8538-e2a2f4757d35','10361WEXSD',24,NULL,236),
 ('caa564bc-211d-48f5-84e6-538211b9e530','aa21b7bc-c6be-403e-8538-e2a2f4757d35','10',9,NULL,2),
 ('cb85a411-7629-4d2d-9d80-eac2b836c326','aa21b7bc-c6be-403e-8538-e2a2f4757d35','JJX',36,NULL,44),
 ('cdab1a05-36d3-40f6-a958-70b945596133','aa21b7bc-c6be-403e-8538-e2a2f4757d35','ANDRES',28,NULL,365),
 ('d64d837f-4d97-4a21-8af8-794476d47096','aa21b7bc-c6be-403e-8538-e2a2f4757d35','FELI',32,NULL,365),
 ('e157e7fe-62c7-4260-8beb-1963dc5ec855','aa21b7bc-c6be-403e-8538-e2a2f4757d35','10361WE',23,NULL,236),
 ('e36a2318-1a14-4006-9a19-b3cefc2c3548','aa21b7bc-c6be-403e-8538-e2a2f4757d35','FELI',33,NULL,365),
 ('e6253d8c-4836-409d-bef4-aa97b3cf58af','aa21b7bc-c6be-403e-8538-e2a2f4757d35','JUL',NULL,'d8afd88c-3741-11eb-9298-6302df5b2bc2',560),
 ('ed6b0f15-145b-46ab-8aaa-aa27d2f520c8','aa21b7bc-c6be-403e-8538-e2a2f4757d35','77',10,NULL,234),
 ('f5bb321f-2c88-44b7-b019-e856a4cb2b2c','aa21b7bc-c6be-403e-8538-e2a2f4757d35','100',7,NULL,89),
 ('fbafe0df-c00e-48f0-b828-af1bca1dd1b4','aa21b7bc-c6be-403e-8538-e2a2f4757d35','77F',12,NULL,234),
 ('fe32ad1e-81a7-47f1-ac46-a57277d26a18','aa21b7bc-c6be-403e-8538-e2a2f4757d35','FREDY',26,NULL,1450),
 ('fe3bc167-8193-4bc7-bd13-3972ca61ecc4','aa21b7bc-c6be-403e-8538-e2a2f4757d35','77FXX',14,NULL,10);
/*!40000 ALTER TABLE `bet_roulette` ENABLE KEYS */;


--
-- Definition of table `color_roulette`
--

DROP TABLE IF EXISTS `color_roulette`;
CREATE TABLE `color_roulette` (
  `id` varchar(45) NOT NULL,
  `color` varchar(255) DEFAULT NULL,
  `is_even_number` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `color_roulette`
--

/*!40000 ALTER TABLE `color_roulette` DISABLE KEYS */;
INSERT INTO `color_roulette` (`id`,`color`,`is_even_number`) VALUES 
 ('d8afd88c-3741-11eb-9298-6302df5b2bc2','Red',1),
 ('dfa10417-3741-11eb-9298-6302df5b2bc2','Black',0);
/*!40000 ALTER TABLE `color_roulette` ENABLE KEYS */;


--
-- Definition of table `roulettes`
--

DROP TABLE IF EXISTS `roulettes`;
CREATE TABLE `roulettes` (
  `id` varchar(45) NOT NULL,
  `date_open` timestamp NULL DEFAULT NULL,
  `date_closed` timestamp NULL DEFAULT NULL,
  `is_closed` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `roulettes`
--

/*!40000 ALTER TABLE `roulettes` DISABLE KEYS */;
INSERT INTO `roulettes` (`id`,`date_open`,`date_closed`,`is_closed`) VALUES 
 ('aa21b7bc-c6be-403e-8538-e2a2f4757d35','2020-12-05 15:27:01','2020-12-06 14:29:35',1),
 ('c2c55907-74e6-4f0f-b74d-b8d7759a9a80','2020-12-05 14:51:15',NULL,0),
 ('c2c55907-74e6-4f0f-bxxx-b8d7759a9a80','2020-12-09 13:42:56',NULL,0),
 ('da0b90ee-28c8-461e-86f3-ce8f9896dba4',NULL,NULL,0);
/*!40000 ALTER TABLE `roulettes` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
