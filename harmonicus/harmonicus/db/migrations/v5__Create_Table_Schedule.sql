CREATE TABLE `schedule` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `date` datetime NOT NULL,
  `hour` datetime NOT NULL,
  `psychologistId` bigint NOT NULL,
  `patientId` bigint NOT NULL,
  `status` int DEFAULT NULL COMMENT '0 - Cancelada, 1 - Agendada, 2 - Realizada, 3 - Remarcada',
  `new_date` datetime NULL,
  PRIMARY KEY (`id`),
  KEY `schedule_FK` (`psychologistId`),
  KEY `schedule_FK_1` (`patientId`),
  CONSTRAINT `schedule_FK` FOREIGN KEY (`psychologistId`) REFERENCES `psychologist` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `schedule_FK_1` FOREIGN KEY (`patientId`) REFERENCES `patient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;