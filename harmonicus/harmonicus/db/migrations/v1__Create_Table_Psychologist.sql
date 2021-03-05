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
  `state` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `country` varchar(70) DEFAULT NULL,
  `avatar` varchar(150) DEFAULT NULL,
  `birth_date` date DEFAULT NULL,
  `crp_region` varchar(70) DEFAULT NULL,
  `file_crp` varchar(150) DEFAULT NULL,
  `file_university_degree` varchar(100) DEFAULT NULL,
  `lates_url` varchar(150) DEFAULT NULL,
  `profissional_title` varchar(100) DEFAULT NULL,
  `short_profile_text` text,
  `completed_training_courses` text,
  `commercial_cep` varchar(9) DEFAULT NULL,
  `commercial_number` int DEFAULT NULL,
  `commercial_street` varchar(100) DEFAULT NULL,
  `commercial_street_add_on` varchar(100) DEFAULT NULL,
  `commercial_district` varchar(100) DEFAULT NULL,
  `commercial_city` varchar(70) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `commercial_state` varchar(40) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;