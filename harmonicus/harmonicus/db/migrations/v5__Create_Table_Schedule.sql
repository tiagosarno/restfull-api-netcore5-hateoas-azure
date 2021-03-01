-- harmonicus.schedule definition

CREATE TABLE `schedule` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `date` datetime NOT NULL,
  `hour` datetime NOT NULL,
  `psychologistId` bigint NOT NULL,
  `patientId` bigint NOT NULL,
  PRIMARY KEY (`id`),
  KEY `schedule_FK` (`psychologistId`),
  KEY `schedule_FK_1` (`patientId`),
  CONSTRAINT `schedule_FK` FOREIGN KEY (`psychologistId`) REFERENCES `psychologist` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `schedule_FK_1` FOREIGN KEY (`patientId`) REFERENCES `patient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;