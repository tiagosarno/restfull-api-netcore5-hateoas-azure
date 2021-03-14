CREATE DEFINER=`root`@`%` TRIGGER `before_insert_patient` BEFORE INSERT ON `patient` FOR EACH ROW BEGIN
  IF new.id IS NULL THEN
    SET new.id = uuid();
  END IF;
END;
