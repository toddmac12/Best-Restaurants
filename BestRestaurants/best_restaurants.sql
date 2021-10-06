-- ---
-- Globals
-- ---

-- SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
-- SET FOREIGN_KEY_CHECKS=0;

-- ---
-- Table 'restaurant'
-- 
-- ---

DROP TABLE IF EXISTS `restaurant`;
		
CREATE TABLE `restaurant` (
  `id` INTEGER NOT NULL AUTO_INCREMENT,
  `id_cuisine` INTEGER NOT NULL,
  `name` VARCHAR(255) NULL DEFAULT NULL,
  `description` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
);

-- ---
-- Table 'reviews'
-- 
-- ---

DROP TABLE IF EXISTS `reviews`;
		
CREATE TABLE `reviews` (
  `id` INTEGER NOT NULL AUTO_INCREMENT,
  `id_restaurant` INTEGER NOT NULL,
  `username` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
);

-- ---
-- Table 'cuisines'
-- 
-- ---

DROP TABLE IF EXISTS `cuisines`;
		
CREATE TABLE `cuisines` (
  `id` INTEGER NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`id`)
);

-- ---
-- Foreign Keys 
-- ---

ALTER TABLE `restaurant` ADD FOREIGN KEY (id_cuisine) REFERENCES `cuisines` (`id`);
ALTER TABLE `reviews` ADD FOREIGN KEY (id_restaurant) REFERENCES `restaurant` (`id`);

-- ---
-- Table Properties
-- ---

-- ALTER TABLE `restaurant` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `reviews` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
-- ALTER TABLE `cuisines` ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- ---
-- Test Data
-- ---

-- INSERT INTO `restaurant` (`id`,`id_cuisine`,`name`,`description`) VALUES
-- ('','','','');
-- INSERT INTO `reviews` (`id`,`id_restaurant`,`username`) VALUES
-- ('','','');
-- INSERT INTO `cuisines` (`id`,`name`) VALUES
-- ('','');