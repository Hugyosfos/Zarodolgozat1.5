-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Ápr 15. 23:31
-- Kiszolgáló verziója: 10.4.25-MariaDB
-- PHP verzió: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `patika`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `gyogyszer`
--

CREATE TABLE `gyogyszer` (
  `id` int(11) NOT NULL,
  `gyogyszerID` varchar(250) COLLATE utf8_hungarian_ci NOT NULL,
  `gyogyszerNev` varchar(250) COLLATE utf8_hungarian_ci NOT NULL,
  `gyogyszerSzam` varchar(250) COLLATE utf8_hungarian_ci NOT NULL,
  `gyogyszerKesz` varchar(250) COLLATE utf8_hungarian_ci NOT NULL,
  `gyogyszerLejarat` varchar(250) COLLATE utf8_hungarian_ci NOT NULL,
  `gyogyszerMenny` bigint(20) NOT NULL,
  `gyogyszerArperDB` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `gyogyszer`
--

INSERT INTO `gyogyszer` (`id`, `gyogyszerID`, `gyogyszerNev`, `gyogyszerSzam`, `gyogyszerKesz`, `gyogyszerLejarat`, `gyogyszerMenny`, `gyogyszerArperDB`) VALUES
(4, '46', 'hjk', '457', '0000-00-00', '2023-05-05', 56, 456);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `gyogyszer`
--
ALTER TABLE `gyogyszer`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `gyogyszer`
--
ALTER TABLE `gyogyszer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
