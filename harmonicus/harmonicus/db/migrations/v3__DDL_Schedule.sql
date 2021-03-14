CREATE TABLE `schedule` (
  `id` char(36) NOT NULL,
  `date` datetime NOT NULL,
  `hour` datetime NOT NULL,
  `psychologistId` char(36) NOT NULL,
  `patientId` char(36) NOT NULL,
  `status` int DEFAULT NULL COMMENT '0 - Cancelada, 1 - Agendada, 2 - Realizada, 3 - Remarcada, 4 - Recebido',
  `new_date` datetime NULL COMMENT 'Este registro ter� valor apenas quando for remarcada a consulta',
  `platform` int DEFAULT NULL COMMENT '1 - Google Meeting, 2 - Zoom, 3 - Skype',
  `price` double(8,2),
  `evaluation` int DEFAULT NULL COMMENT 'Valores de 1 a 5',
  `patient_note` varchar(200) DEFAULT NULL COMMENT 'Alguma observa��o do paciente deixada ap�s avalia��o da consulta',
  `public_evaluation` int DEFAULT NULL COMMENT '0 - Paciente n�o quer se identificar para o psic�logo, 1 - Divulgar identidade para o psic�logo',
  PRIMARY KEY (`id`),
  KEY `schedule_FK` (`psychologistId`),
  KEY `schedule_FK_1` (`patientId`),
  CONSTRAINT `schedule_FK` FOREIGN KEY (`psychologistId`) REFERENCES `psychologist` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `schedule_FK_1` FOREIGN KEY (`patientId`) REFERENCES `patient` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
);