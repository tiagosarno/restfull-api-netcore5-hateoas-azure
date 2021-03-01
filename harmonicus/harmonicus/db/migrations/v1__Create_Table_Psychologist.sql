-- harmonicus.psychologist definition

CREATE TABLE `psychologist` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `account_status` int DEFAULT NULL,
  `registration_date` datetime DEFAULT NULL,
  `name` varchar(160) DEFAULT NULL,
  `email` varchar(180) DEFAULT NULL,
  `cpf` varchar(11) DEFAULT NULL,
  `gender` char(1) DEFAULT NULL,
  `phone` bigint DEFAULT NULL,
  `phone_is_whatsapp` int DEFAULT NULL,
  `crp` varchar(20) DEFAULT NULL,
  `curriculum` varchar(100) DEFAULT NULL,
  `how_find_harmonicus` varchar(100) DEFAULT NULL,
  `know_zoom` int DEFAULT NULL,
  `know_google_meeting` int DEFAULT NULL,
  `know_skype` int DEFAULT NULL,
  `city` varchar(140) DEFAULT NULL,
  `state` varchar(70) DEFAULT NULL,
  `country` varchar(70) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;