/*
Navicat MySQL Data Transfer

Source Server         : vm-mysql
Source Server Version : 50541
Source Host           : vm-mysql:3306
Source Database       : web_connect

Target Server Type    : MYSQL
Target Server Version : 50699
File Encoding         : 65001

Date: 2022-04-25 11:37:37
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for wc_copaso_candidate
-- ----------------------------
DROP TABLE IF EXISTS `wc_copaso_candidate`;
CREATE TABLE `wc_copaso_candidate` (
`IdCandidate`  int(11) NOT NULL AUTO_INCREMENT ,
`Document`  varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Name`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Lastname`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdCandidate`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=11

;

-- ----------------------------
-- Table structure for wc_copaso_employee
-- ----------------------------
DROP TABLE IF EXISTS `wc_copaso_employee`;
CREATE TABLE `wc_copaso_employee` (
`IdEmployee`  int(11) NOT NULL AUTO_INCREMENT ,
`Document`  varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Name`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Lastname`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`HasVoted`  int(1) NOT NULL DEFAULT 0 ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdEmployee`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=1719

;

-- ----------------------------
-- Table structure for wc_copaso_vote
-- ----------------------------
DROP TABLE IF EXISTS `wc_copaso_vote`;
CREATE TABLE `wc_copaso_vote` (
`IdVote`  int(11) NOT NULL AUTO_INCREMENT ,
`Candidate`  varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`SecurityInfo`  varchar(1000) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdVote`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=435

;

-- ----------------------------
-- Table structure for wc_dependence
-- ----------------------------
DROP TABLE IF EXISTS `wc_dependence`;
CREATE TABLE `wc_dependence` (
`IdDependence`  int(11) NOT NULL ,
`Name`  varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`State`  int(1) NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdDependence`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci

;

-- ----------------------------
-- Table structure for wc_elections_candidate
-- ----------------------------
DROP TABLE IF EXISTS `wc_elections_candidate`;
CREATE TABLE `wc_elections_candidate` (
`IdCandidate`  int(11) NOT NULL AUTO_INCREMENT ,
`DocumentType`  int(1) NOT NULL ,
`DocumentNumber`  varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Name`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Lastname`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`ProgramId`  int(11) NOT NULL ,
`Type`  int(1) NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdCandidate`),
FOREIGN KEY (`ProgramId`) REFERENCES `wc_program` (`IdProgram`) ON DELETE RESTRICT ON UPDATE RESTRICT,
INDEX `fk_elections_candidate_program_id` (`ProgramId`) USING BTREE 
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=42

;

-- ----------------------------
-- Table structure for wc_elections_registered
-- ----------------------------
DROP TABLE IF EXISTS `wc_elections_registered`;
CREATE TABLE `wc_elections_registered` (
`IdRegister`  int(11) NOT NULL AUTO_INCREMENT ,
`RegisterType`  int(1) NOT NULL ,
`DocumentType`  int(1) NOT NULL ,
`DocumentNumber`  varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`ProgramId`  int(11) NOT NULL ,
`StudentCode`  varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Semester`  varchar(2) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Name`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Lastname`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Phone`  varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Cellphone`  varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL ,
`Email`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Address`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Title`  varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`item1`  varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`item2`  varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`item3`  varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdRegister`),
FOREIGN KEY (`ProgramId`) REFERENCES `wc_program` (`IdProgram`) ON DELETE RESTRICT ON UPDATE RESTRICT,
UNIQUE INDEX `idx_document_number` (`DocumentNumber`) USING BTREE ,
INDEX `fk_election_registered_program_id` (`ProgramId`) USING BTREE 
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=30

;

-- ----------------------------
-- Table structure for wc_elections_vote
-- ----------------------------
DROP TABLE IF EXISTS `wc_elections_vote`;
CREATE TABLE `wc_elections_vote` (
`IdVote`  int(11) NOT NULL AUTO_INCREMENT ,
`DocumentNumber`  varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`SecurityInfo`  varchar(1000) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdVote`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=881

;
-- ----------------------------
-- Table structure for wc_elections_voters
-- ----------------------------
DROP TABLE IF EXISTS `wc_elections_voters`;
CREATE TABLE `wc_elections_voters` (
`IdVoter`  int(11) NOT NULL AUTO_INCREMENT ,
`DocumentType`  int(1) NOT NULL ,
`DocumentNumber`  varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Name`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Lastname`  varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`ProgramId`  int(11) NOT NULL ,
`VoterType`  int(1) NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdVoter`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=10314

;

-- ----------------------------
-- Table structure for wc_elections_voting
-- ----------------------------
DROP TABLE IF EXISTS `wc_elections_voting`;
CREATE TABLE `wc_elections_voting` (
`IdVoting`  int(11) NOT NULL AUTO_INCREMENT ,
`Candidate`  varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Type`  int(1) NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdVoting`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=881

;


-- ----------------------------
-- Table structure for wc_faculty
-- ----------------------------
DROP TABLE IF EXISTS `wc_faculty`;
CREATE TABLE `wc_faculty` (
`IdFaculty`  int(11) NOT NULL AUTO_INCREMENT ,
`Name`  varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`State`  int(1) NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdFaculty`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=7

;


-- ----------------------------
-- Table structure for wc_program
-- ----------------------------
DROP TABLE IF EXISTS `wc_program`;
CREATE TABLE `wc_program` (
`IdProgram`  int(11) NOT NULL AUTO_INCREMENT ,
`IdFaculty`  int(11) NOT NULL ,
`Name`  varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`State`  int(1) NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdProgram`),
FOREIGN KEY (`IdFaculty`) REFERENCES `wc_faculty` (`IdFaculty`) ON DELETE RESTRICT ON UPDATE RESTRICT,
INDEX `fk_program_faculty_id` (`IdFaculty`) USING BTREE 
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=23

;


-- ----------------------------
-- Table structure for wc_reservations
-- ----------------------------
DROP TABLE IF EXISTS `wc_reservations`;
CREATE TABLE `wc_reservations` (
`IdReservation`  int(11) NOT NULL AUTO_INCREMENT ,
`Date`  datetime NOT NULL ,
`StartTime`  int(11) NOT NULL ,
`EndTime`  int(11) NOT NULL ,
`Room`  int(11) NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdReservation`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=1

;

-- ----------------------------
-- Records of wc_reservations
-- ----------------------------
BEGIN;
COMMIT;

-- ----------------------------
-- Table structure for wc_rooms
-- ----------------------------
DROP TABLE IF EXISTS `wc_rooms`;
CREATE TABLE `wc_rooms` (
`IdRoom`  int(11) NOT NULL AUTO_INCREMENT ,
`Name`  varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`Capacity`  int(3) NOT NULL ,
`IdRoomType`  int(11) NOT NULL ,
`State`  int(1) NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdRoom`),
FOREIGN KEY (`IdRoomType`) REFERENCES `wc_rooms_type` (`IdRoomType`) ON DELETE RESTRICT ON UPDATE RESTRICT,
INDEX `fk_wb_toom_type_idRoomType` (`IdRoomType`) USING BTREE 
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=5

;

-- ----------------------------
-- Table structure for wc_rooms_type
-- ----------------------------
DROP TABLE IF EXISTS `wc_rooms_type`;
CREATE TABLE `wc_rooms_type` (
`IdRoomType`  int(11) NOT NULL AUTO_INCREMENT ,
`Description`  varchar(200) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL ,
`State`  int(1) NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdRoomType`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=4

;

-- ----------------------------
-- Table structure for wc_time
-- ----------------------------
DROP TABLE IF EXISTS `wc_time`;
CREATE TABLE `wc_time` (
`IdTime`  int(11) NOT NULL AUTO_INCREMENT ,
`Hour`  int(2) NOT NULL ,
`Minute`  int(2) NOT NULL ,
`Meridian`  int(1) NOT NULL ,
`CreationDate`  timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP ,
PRIMARY KEY (`IdTime`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_general_ci
AUTO_INCREMENT=34

;


