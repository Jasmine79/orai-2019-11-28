-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Nov 28. 19:27
-- Kiszolgáló verziója: 10.1.26-MariaDB
-- PHP verzió: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `latvanyossagokdb`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `latvanyossagok`
--

CREATE TABLE `latvanyossagok` (
  `id` int(11) NOT NULL,
  `nev` varchar(200) NOT NULL,
  `leiras` varchar(1500) NOT NULL,
  `ar` int(11) NOT NULL DEFAULT '0',
  `varos_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `varosok`
--

CREATE TABLE `varosok` (
  `id` int(11) NOT NULL,
  `nev` varchar(200) NOT NULL,
  `lakossag` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `varosok`
--

INSERT INTO `varosok` (`id`, `nev`, `lakossag`) VALUES
(1, 'Debrecen', 200000),
(2, 'Budapest', 1),
(4, 'weqdfqwerf', 5);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `latvanyossagok`
--
ALTER TABLE `latvanyossagok`
  ADD PRIMARY KEY (`id`),
  ADD KEY `latvanyossagok_ibfk_1` (`varos_id`);

--
-- A tábla indexei `varosok`
--
ALTER TABLE `varosok`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nev` (`nev`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `latvanyossagok`
--
ALTER TABLE `latvanyossagok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `varosok`
--
ALTER TABLE `varosok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
