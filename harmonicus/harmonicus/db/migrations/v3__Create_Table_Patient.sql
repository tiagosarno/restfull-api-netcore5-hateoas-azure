-- harmonicus.patients definition

CREATE TABLE `patient` (
  `id` bigint NOT NULL AUTO_INCREMENT,  
  `first_name` varchar(80) NOT NULL,  
  `last_name` varchar(80) NOT NULL,
  `email` varchar(160) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `address` varchar(100) NULL,
  `gender` varchar(6) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;