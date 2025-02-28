

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";



CREATE DATABASE IF NOT EXISTS `blog` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `blog`;



DROP TABLE IF EXISTS `blogtable`;
CREATE TABLE IF NOT EXISTS `blogtable` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `bekudesiido` datetime NOT NULL,
  `post` text NOT NULL,
  `UserId` int(11) NOT NULL,
  `temakID` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `UserId` (`UserId`),
  KEY `temakID` (`temakID`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;



INSERT INTO `blogtable` (`Id`, `bekudesiido`, `post`, `UserId`, `temakID`) VALUES
(4, '2025-02-28 11:54:39', 'szeretem a narancsot', 1, 0);



DROP TABLE IF EXISTS `blogtemak`;
CREATE TABLE IF NOT EXISTS `blogtemak` (
  `ID` int(50) NOT NULL AUTO_INCREMENT,
  `beszelgetesneve` varchar(50) NOT NULL,
  `createdtime` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;


INSERT INTO `blogtemak` (`ID`, `beszelgetesneve`, `createdtime`) VALUES
(1, 'narancs', '2025-02-28 11:01:11');



DROP TABLE IF EXISTS `usertable`;
CREATE TABLE IF NOT EXISTS `usertable` (
  `Id` int(20) NOT NULL AUTO_INCREMENT,
  `UserName` text NOT NULL,
  `Email` text NOT NULL,
  `Password` text NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserName` (`UserName`) USING HASH
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4;


INSERT INTO `usertable` (`Id`, `UserName`, `Email`, `Password`) VALUES
(1, 'peti01', 'peti01@gmail.com', 'alma'),
(2, 'Humfried O\'Carran', 'hocarran0@nsw.gov.au', 'zK1%1>|2S*DjE{oX'),
(3, 'Keeley Leile', 'kleile1@globo.com', 'dU0/fP>YD'),
(4, 'Pietro Owen', 'powen2@mtv.com', 'dA2`6Y#l'),
(5, 'Benton Brownett', 'bbrownett3@vkontakte.ru', 'sQ0|rB$oY=i1/23Z'),
(6, 'Shelden Brass', 'sbrass4@phoca.cz', 'oP6(VAtJs'),
(7, 'Dennie Mattiello', 'dmattiello5@soup.io', 'sP6#GN`0'),
(8, 'Marcellina Diwell', 'mdiwell6@whitehouse.gov', 'gT6*mX#8+72\"G'),
(9, 'Corly De Rye Barrett', 'cde7@dropbox.com', 'zV6+)po/*!`RDq1'),
(10, 'Fanny McTrusty', 'fmctrusty8@vk.com', 'oX27m1\'QCDcA'),
(11, 'Bernadina Gosart', 'bgosart9@rediff.com', 'rD2)2OzM.PT.jy'),
(12, 'Sydelle Delhanty', 'sdelhantya@abc.net.au', 'hZ0.$cyZTs\'b'),
(13, 'Greg Cotte', 'gcotteb@globo.com', 'zI6>}u+\'g|{VFS'),
(14, 'Alvinia Bruntjen', 'abruntjenc@umn.edu', 'fO6_oZ0\'ez4j@3r('),
(15, 'Gail Damant', 'gdamantd@google.com.br', 'hA0_YRD.z_v|n{'),
(16, 'Janeta Cliss', 'jclisse@dedecms.com', 'rH4+P11%z7e+fBFM'),
(17, 'Jarrad Dockwra', 'jdockwraf@auda.org.au', 'dF4=+KYB\"gHar)iK'),
(18, 'Erhart Buzin', 'ebuzing@prlog.org', 'mS6~\'{>`w>!'),
(19, 'Magdaia Gamell', 'mgamellh@apple.com', 'zE5.0.vZ8hu'),
(20, 'Christophe Place', 'cplacei@symantec.com', 'oQ8`EP}2%mlG\''),
(21, 'Alfonse Boc', 'abocj@npr.org', 'nG6)o?7kC{%/');


ALTER TABLE `blogtable`
  ADD CONSTRAINT `blogtable_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `usertable` (`Id`) ON DELETE CASCADE;
COMMIT;

