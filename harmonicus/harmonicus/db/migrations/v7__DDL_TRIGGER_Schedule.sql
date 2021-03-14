CREATE DEFINER=`root`@`%` TRIGGER `before_insert_schedule` BEFORE INSERT ON `schedule` FOR EACH ROW BEGIN
  IF new.id IS NULL THEN
    SET new.id = uuid();
  END IF;
END;
