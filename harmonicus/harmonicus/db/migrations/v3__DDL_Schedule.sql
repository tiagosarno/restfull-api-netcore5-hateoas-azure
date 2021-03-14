CREATE TABLE `schedule` (
  `id` char(36) NOT NULL,
  `date` datetime NOT NULL,
  `hour` datetime NOT NULL,
  `psychologistId` char(36) NOT NULL,
  `patientId` char(36) NOT NULL,
  `status` int DEFAULT NULL COMMENT '0 - Cancelada, 1 - Agendada, 2 - Realizada, 3 - Remarcada',
  `new_date` datetime NULL,
  `platform` int DEFAULT NULL COMMENT '1 - Google Meeting, 2 - Zoom, 3 - Skype',
  PRIMARY KEY (`id`),
  KEY `schedule_FK` (`psychologistId`),
  KEY `schedule_FK_1` (`patientId`),
  CONSTRAINT `schedule_FK` FOREIGN KEY (`psychologistId`) REFERENCES `psychologist` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `schedule_FK_1` FOREIGN KEY (`patientId`) REFERENCES `patient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
);