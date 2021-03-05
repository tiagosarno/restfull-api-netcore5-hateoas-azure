-- harmonicus.patient definition

CREATE TABLE `patient` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `first_name` varchar(80) NOT NULL,
  `last_name` varchar(80) NOT NULL,
  `email` varchar(160) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `address` varchar(100) DEFAULT NULL,
  `gender` varchar(6) NOT NULL,
  `phone` bigint DEFAULT NULL,
  `phone_is_whatsapp` int DEFAULT NULL,
  `how_find_harmonicus` varchar(100) DEFAULT NULL,
  `know_zoom` int DEFAULT NULL,
  `know_google_meeting` int DEFAULT NULL,
  `know_skype` int DEFAULT NULL,
  `city` varchar(140) DEFAULT NULL,
  `state` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `country` varchar(70) DEFAULT NULL,
  `avatar` varchar(150) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `status` int DEFAULT NULL,
  `authorization_term` varchar(150) DEFAULT NULL,
  `responsible_cpf` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;