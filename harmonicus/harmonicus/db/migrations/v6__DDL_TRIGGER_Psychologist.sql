CREATE DEFINER=`root`@`%` TRIGGER `before_insert_psychologist` BEFORE INSERT ON `psychologist` FOR EACH ROW BEGIN
  IF new.id IS NULL THEN
    SET new.id = uuid();
  END IF;
END;
