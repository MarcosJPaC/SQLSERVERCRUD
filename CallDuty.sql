USE master;
GO
IF DB_ID(N'CallDuty')IS NOT NULL

CREATE DATABASE CallDuty
ON
(NAME = CallDuty_dat,
FILENAME= 'C:\BaseDatos\CallDuty.mdf',
SIZE = 10,
MAXSIZE = 50,
FILEGROWTH = 5)
LOG ON 
(NAME =CallDuty_log,
FILENAME = 'C:\BaseDatos\CallDuty.ldf',
SIZE = 5MB,
MAXSIZE = 25MB,
FILEGROWTH = 5MB);
GO
USE CallDuty;
GO
CREATE TABLE Actor
(
idActor INT identity (1,1),
nombre VARCHAR(50) NOT NULL,
fechaNacimiento DATETIME NOT NULL,
tipoDeContrato VARCHAR(50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Agente
(
idAgente INT identity (1,1),
nombre VARCHAR(50) NOT NULL,
edad INT NOT NULL,
nacionalidad VARCHAR (50) NOT NULL,
idActor INT NOT NULL,
idBarracon INT NOT NULL,
idInventario INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
--
CREATE TABLE Armerio
(
idArmerio INT identity (1,1),
slot VARCHAR (50) NOT NULL,
armas VARCHAR (50) NOT NULL,
mejoras VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
--
CREATE TABLE Barracon
(
idBarracon INT identity (1,1),
tarjetaDeVisita INT NOT NULL,
calidad VARCHAR (50) NOT NULL,
precio char (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE BattlePass
(
idBattlePass INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
nivelActual VARCHAR(50) NOT NULL,
recompensa VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Camuflaje
(
idCamuflaje INT identity (1,1),
color VARCHAR(50) NOT NULL,
precio VARCHAR (50) NOT NULL,
tieneAnimacion BIT DEFAULT 1 NOT NULL,
idArmerio INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Capitulo
(
idCapitulo INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
juego VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Cinematica
(
idCinematica INT identity (1,1),
duracion VARCHAR (50) NOT NULL,
perteneceAModo VARCHAR (50) NOT NULL,
sePuedeSaltar BIT DEFAULT 1 NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Clase
(
idClase INT identity (1,1),
slot INT NOT NULL,
armaPrincipal VARCHAR (50) NOT NULL,
ArmaSecundaria VARCHAR (50) NOT NULL,
idArmerio INT not null,
idJugador INT not null,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Clasificatoria 
(
idClasificatoria INT identity (1,1),
rangoNecesario VARCHAR (50) NOT NULL,
puedeRankear BIT DEFAULT 1 NOT NULL,
rangoActual VARCHAR (50) NOT NULL,
idProgreso INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Clip
(
idClip INT identity (1,1),
numeroClip char(2) NOT NULL,
autor VARCHAR (50) NOT NULL,
duracion VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Club
(
idClub INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
integrante VARCHAR (50) NOT NULL,
plataforma VARCHAR (50) NOT NULL,
idComunidad int NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Coalicion 
(
idCoalicion INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
cantidadIntegrentes CHAR (50) NOT NULL,
paisOrigen VARCHAR (50) NOT NULL,
idAgente INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Colaboracion 
(
idColaboracion INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
inicioColaboracion DATETIME  NOT NULL,
finColaboracion DATETIME NOT NULL,
idExclusiva INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Compra
(
idCompra INT identity (1,1),
precio INT NOT NULL,
comprasRealizadas VARCHAR (50) NOT NULL,
devoluciones VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
idJugador INT NOT NULL,
);
GO
CREATE TABLE Comunidad
(
idComunidad INT identity (1,1),
nacionalidad VARCHAR (50) NOT NULL,
juego VARCHAR (50) NOT NULL,
usuariosConectados CHAR (2) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Configuracion
(
idConfiguracion INT identity (1,1),
nivelDeBrillo CHAR (50) NOT NULL,
sensibilidad VARCHAR (50) NOT NULL,
idioma VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Desafio
(
idDesafio INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
recompensa VARCHAR (50) NOT NULL,
nivelNecesario VARCHAR (50) NOT NULL,
idMision INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Desarrollador
(
idDesarrollador INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
telefono VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Dlc
(
idDlc INT identity (1,1),
precio INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
fechaDeSalida DATETIME NOT NULL,
idTienda INT NOT NULL,
idMapa INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Emblema
(
idEmblema INT identity (1,1),
color VARCHAR (50) NOT NULL,
tamaño CHAR (50) NOT NULL,
figura VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Escuadron
(
idEscuadron INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
integrantes CHAR (50) NOT NULL,
idAgente INT NOT NULL,
idModo INT NOT NULL,
idPartida INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Evento
(
idEvento INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
fechaInicio DATETIME NOT NULL,
fechaFin DATETIME NOT NULL,
idModo INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Exclusiva
(
idExclusiva INT identity (1,1),
contenido VARCHAR (50) NOT NULL,
plataforma VARCHAR (50) NOT NULL,
fechaInicio DATETIME NOT NULL,
idModo INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Ficha
(
idFicha INT identity (1,1),
duracion INT NOT NULL,
valor VARCHAR (50) NOT NULL,
potencia VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Fupgrade
(
idFupgrade INT identity (1,1),
duracion CHAR (2) NOT NULL,
nombre VARCHAR (50) NOT NULL,
killNecesarias VARCHAR (2) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Gesto
(
idGesto INT identity (1,1),
calidad VARCHAR (50) NOT NULL,
temporadaSalida VARCHAR (50) NOT NULL,
tipo VARCHAR (50) NOT NULL,
idAgente INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Inventario
(
idInventario INT identity (1,1),
calidad VARCHAR (50) NOT NULL,
objeto VARCHAR (50) NOT NULL,
cantidad VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Jugador
(
idJugador INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
fechaCreacion DATETIME NOT NULL,
privilegios VARCHAR (50) NOT NULL,
idEmblema INT NOT NULL,
idClub INT NOT NULL,
idNivel INT NOT NULL,
idFupgrade INT NOT NULL,
idProgreso INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Loot
(
idLoot INT identity (1,1),
tipo VARCHAR (50) NOT NULL,
cantidad CHAR (50) NOT NULL,
calidad VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
idMapa INT NOT NULL,
idFupgrade INT NOT NULL,
);
GO
CREATE TABLE Mapa
(
idMapa INT identity (1,1),
categoria INT NOT NULL,
tamaño DATETIME NOT NULL,
idSoundtrack INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Mision
(
idMision INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
jugabilidad INT NOT NULL,
duracion INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Modo
(
idModo INT identity (1,1),
jugadoresNecesarios INT NOT NULL,
tamaño VARCHAR (50) NOT NULL,
duracion VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Moneda 
(
idMoneda INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
precio VARCHAR (50) NOT NULL,
idJugador INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Nivel
(
idNivel INT identity (1,1),
identificador VARCHAR (50) NOT NULL,
recompensa INT NOT NULL,
desbloqueo INT NOT NULL,
idFicha INT NOT NULL,
idPrestigio INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Parche
(
idParche INT identity (1,1),
serie VARCHAR (50) NOT NULL,
fecha DATETIME  NOT NULL,
versión int NOT NULL,
idVersion INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Partida
(
idPartida INT identity (1,1),
cantidadJugadores INT  NOT NULL,
duracion VARCHAR (50) NOT NULL,
squadGanador VARCHAR (50) NOT NULL,
idCinematica INT NOT NULL,
idPractica INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Plataforma
(
idPlataforma INT identity (1,1),
requisitos VARCHAR (50) NOT NULL,
nombre VARCHAR (50) NOT NULL,
idConfiguracion INT NOT NULL,
idVersion INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Practica
(
idPractica INT identity (1,1),
stage VARCHAR (50) NOT NULL,
dificultadPractica INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Prestigio
(
idPrestigio INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
nivelPrestigio INT NOT NULL,
prestigioAnterior INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Progreso
(
idProgreso INT identity (1,1),
misionesCompletadas VARCHAR (50) NOT NULL,
mejorPuntuacion INT NOT NULL,
rangoAnterior INT  NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Proyecto
(
idProyecto INT identity (1,1),
nombre VARCHAR (50) NOT NULL,
arma VARCHAR (50) NOT NULL,
precio INT NOT NULL,
idTienda INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Racha
(
idRacha INT identity (1,1),
puntosNecesaraios VARCHAR (50) NOT NULL,
nivelDesbloqueo INT NOT NULL,
idArmerio INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Soundtrack
(
idSoundtrack INT identity (1,1),
autor VARCHAR (50) NOT NULL,
nombre VARCHAR (50) NOT NULL,
duracion VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Suscripcion
(
idSuscripcion INT identity (1,1),
precio VARCHAR (50) NOT NULL,
tipo VARCHAR (50) NOT NULL,
idBattlePass INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Temporada
(
idTemporada INT identity (1,1),
nombreTemporada VARCHAR (50) NOT NULL,
inicio DATETIME NOT NULL,
final DATETIME NOT NULL,
idBattlePass INT NOT NULL,
idDesarrollador INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Tienda
(
idTienda INT identity (1,1),
producto VARCHAR (50) NOT NULL,
ofertas VARCHAR (50) NOT NULL,
precio INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Vehiculo
(
idVehiculo INT identity (1,1),
numeroPasajeros INT NOT NULL,
tieneArtilleria BIT DEFAULT 1 NOT NULL,
tipo VARCHAR (50) NOT NULL,
idCamuflaje INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Ventaja
(
idVentaja INT identity (1,1),
tiempoDeRecarga VARCHAR (50) NOT NULL,
nombre VARCHAR (50) NOT NULL,
killsNecesarias INT NOT NULL,
idArmerio INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE Versión
(
idVersion INT identity (1,1),
cambios VARCHAR (50) NOT NULL,
juegoAlQuePertenece VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO

CREATE TABLE AgenteEscuadron
(
idAgenteEscuadron INT identity (1,1),
idAgente INT NOT NULL,
idEscuadron INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE AgenteGesto
(
idAgenteGesto INT identity (1,1),
idAgente INT NOT NULL,
idGesto INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE BarraconVehiculo
(
idBarraconVehiculo INT identity (1,1),
idBarracon INT NOT NULL,
idVehiculo INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE ClipPartida
(
idClipPartida INT identity (1,1),
idClip INT NOT NULL,
idPartida INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
);
GO
CREATE TABLE CapituloTemporada
(
idCapituloTemporada INT identity (1,1),
idCapitulo INT NOT NULL,
idTemporada INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE DesafioBattlepass
(
idDesafioBattlepass INT identity (1,1),
idBattlePass INT NOT NULL,
idDesafio INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE EscuadronAgente
(
idEscuadronAgente INT identity (1,1),
idEscuadron INT NOT NULL,
idAgente INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE JugadorPlataforma
(
idJugadorPlataforma INT identity (1,1),
idJugador INT NOT NULL,
idPlataforma INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO
CREATE TABLE MapaTemporada
(
idMapaTemporada INT identity (1,1),
idMapa INT NOT NULL,
idTemporada INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL
);
GO

--------------------------------INDEX------------------------------
CREATE INDEX IX_Actor ON Actor(idActor);
GO
CREATE INDEX IX_Agente ON Agente(idAgente);
GO
CREATE INDEX IX_Armerio ON Armerio(idArmerio);
GO
CREATE INDEX IX_Barracon ON Barracon(idBarracon);
GO
CREATE INDEX IX_BattlePass ON BattlePass(idBattlePass);
GO
CREATE INDEX IX_Camuflaje ON Camuflaje(idCamuflaje);
GO
CREATE INDEX IX_Capitulo ON Capitulo(idCapitulo);
GO
CREATE INDEX IX_Cinematica ON Cinematica(idCinematica);
GO
CREATE INDEX IX_Clase ON Clase(idClase);
GO
CREATE INDEX IX_Clasificatoria ON Clasificatoria(idClasificatoria);
GO
CREATE INDEX IX_Clip ON Clip(idClip);
GO
CREATE INDEX IX_Club ON Club(idClub);
GO
CREATE INDEX IX_Coalicion ON Coalicion(idCoalicion);
GO
CREATE INDEX IX_Colaboracion ON Colaboracion(idColaboracion);
GO
CREATE INDEX IX_Compra ON Compra(idCompra);
GO
CREATE INDEX IX_Comunidad ON Comunidad(idComunidad);
GO
CREATE INDEX IX_Configuracion ON Configuracion(idConfiguracion);
GO
CREATE INDEX IX_Desafio ON Desafio(idDesafio);
GO
CREATE INDEX IX_Desarrollador ON Desarrollador(idDesarrollador);
GO
CREATE INDEX IX_Dlc ON Dlc(idDlc);
GO
CREATE INDEX IX_Emblema ON Emblema(idEmblema);
GO
CREATE INDEX IX_Escuadron ON Escuadron(idEscuadron);
GO
CREATE INDEX IX_Evento ON Evento(idEvento);
GO
CREATE INDEX IX_Exclusiva ON Exclusiva(idExclusiva);
GO
CREATE INDEX IX_Ficha ON Ficha(idFicha);
GO
CREATE INDEX IX_Fupgrade ON Fupgrade(idFupgrade);
GO
CREATE INDEX IX_Gesto ON Gesto(idGesto);
GO
CREATE INDEX IX_Inventario ON Inventario(idInventario);
GO
CREATE INDEX IX_Jugador ON Jugador(idJugador);
GO
CREATE INDEX IX_Loot ON Loot(idLoot);
GO
CREATE INDEX IX_Mapa ON Mapa(idMapa);
GO
CREATE INDEX IX_Mision ON Mision(idMision);
GO
CREATE INDEX IX_Modo ON Modo(idModo);
GO
CREATE INDEX IX_Nivel ON Nivel(idNivel);
GO
CREATE INDEX IX_Parche ON Parche(idParche);
GO
CREATE INDEX IX_Partida ON Partida(idPartida);
GO
CREATE INDEX IX_Plataforma ON Plataforma(idPlataforma);
GO
CREATE INDEX IX_Practica ON Practica(idPractica);
GO
CREATE INDEX IX_Prestigio ON Prestigio(idPrestigio);
GO
CREATE INDEX IX_Proyecto ON Proyecto(idProyecto);
GO
CREATE INDEX IX_Racha ON Racha(idRacha);
GO
CREATE INDEX IX_Soundtrack ON Soundtrack(idSoundtrack);
GO
CREATE INDEX IX_Suscripcion ON Suscripcion(idSuscripcion);
GO
CREATE INDEX IX_Temporada ON Temporada(idTemporada);
GO
CREATE INDEX IX_Tienda ON Tienda(idTienda);
GO
CREATE INDEX IX_Vehiculo ON Vehiculo(idVehiculo);
GO
CREATE INDEX IX_Ventaja ON Ventaja(idVentaja);
GO
CREATE INDEX IX_Version ON Versión(idVersion);
GO
CREATE INDEX IX_AgenteEscuadron ON AgenteEscuadron(idAgenteEscuadron);
GO
CREATE INDEX IX_AgenteGesto ON AgenteGesto(idAgenteGesto);
GO
CREATE INDEX IX_BarraconVehiculo ON BarraconVehiculo(idBarraconVehiculo);
GO
CREATE INDEX IX_CapituloTemporada ON CapituloTemporada(idCapituloTemporada);
GO
CREATE INDEX IX_DesafioBattlePass ON DesafioBattlepass(idDesafioBattlepass);
GO
CREATE INDEX IX_EscuadronAgente ON EscuadronAgente(idEscuadronAgente);
GO
CREATE INDEX IX_JugadorPlataforma ON JugadorPlataforma(idJugadorPlataforma);
GO
CREATE INDEX IX_MapaTemporada ON MapaTemporada(idMapaTemporada);
GO
CREATE INDEX IX_ClipPartida ON ClipPartida(idClipPartida);


ALTER TABLE Actor ADD CONSTRAINT PK_Actor PRIMARY KEY (idActor)
ALTER TABLE Agente ADD CONSTRAINT PK_Agente PRIMARY KEY (idAgente)
ALTER TABLE Armerio ADD CONSTRAINT PK_Armeria PRIMARY KEY (idArmerio)
ALTER TABLE Barracon ADD CONSTRAINT PK_Barracon PRIMARY KEY (idBarracon)
ALTER TABLE Battlepass ADD CONSTRAINT PK_Battlepass PRIMARY KEY (idBattlePass)
ALTER TABLE Camuflaje ADD CONSTRAINT PK_Camuflaje PRIMARY KEY (idCamuflaje)
ALTER TABLE Capitulo ADD CONSTRAINT PK_Capitulo PRIMARY KEY (idCapitulo)
ALTER TABLE Cinematica ADD CONSTRAINT PK_Cinematica PRIMARY KEY (idCinematica)
ALTER TABLE Clase ADD CONSTRAINT PK_Clase PRIMARY KEY (idClase)
ALTER TABLE Clasificatoria ADD CONSTRAINT PK_Clasificatoria PRIMARY KEY (idClasificatoria)
ALTER TABLE Clip ADD CONSTRAINT PK_Clip PRIMARY KEY (idClip)
ALTER TABLE Club ADD CONSTRAINT PK_Club PRIMARY KEY (idClub)
ALTER TABLE Coalicion ADD CONSTRAINT PK_Coalicion PRIMARY KEY (idCoalicion)
ALTER TABLE Colaboracion ADD CONSTRAINT PK_Colaboracion PRIMARY KEY (idColaboracion)
ALTER TABLE Compra ADD CONSTRAINT PK_Compra PRIMARY KEY (idCompra)
ALTER TABLE Comunidad ADD CONSTRAINT PK_Comunidad PRIMARY KEY (idComunidad)
ALTER TABLE Configuracion ADD CONSTRAINT PK_Configuracion PRIMARY KEY (idConfiguracion)
ALTER TABLE Desafio ADD CONSTRAINT PK_Desafio PRIMARY KEY (idDesafio)
ALTER TABLE Desarrollador ADD CONSTRAINT PK_Desarrollador PRIMARY KEY (idDesarrollador)
ALTER TABLE Dlc ADD CONSTRAINT PK_Dlc PRIMARY KEY (idDlc)
ALTER TABLE Emblema ADD CONSTRAINT PK_Emblema PRIMARY KEY (idEmblema)
ALTER TABLE Escuadron ADD CONSTRAINT PK_Escuadron PRIMARY KEY (idEscuadron)
ALTER TABLE Evento ADD CONSTRAINT PK_Evento PRIMARY KEY (idEvento)
ALTER TABLE Exclusiva ADD CONSTRAINT PK_Exclusiva PRIMARY KEY (idExclusiva)
ALTER TABLE Ficha ADD CONSTRAINT PK_Ficha PRIMARY KEY (idFicha)
ALTER TABLE Fupgrade ADD CONSTRAINT PK_Fupgrade PRIMARY KEY (idFupgrade)
ALTER TABLE Gesto ADD CONSTRAINT PK_Gesto PRIMARY KEY (idGesto)
ALTER TABLE Inventario ADD CONSTRAINT PK_Inventario PRIMARY KEY (idInventario)
ALTER TABLE Jugador ADD CONSTRAINT PK_Jugador PRIMARY KEY (idJugador)
ALTER TABLE Loot ADD CONSTRAINT PK_Loot PRIMARY KEY (idLoot)
ALTER TABLE Mapa ADD CONSTRAINT PK_Mapa PRIMARY KEY (idMapa)
ALTER TABLE Mision ADD CONSTRAINT PK_Mision PRIMARY KEY (idMision)
ALTER TABLE Modo ADD CONSTRAINT PK_Modo PRIMARY KEY (idModo)
ALTER TABLE Moneda ADD CONSTRAINT PK_Moneda PRIMARY KEY (idMoneda)
ALTER TABLE Nivel ADD CONSTRAINT PK_Nivel PRIMARY KEY (idNivel)
ALTER TABLE Parche ADD CONSTRAINT PK_Parche PRIMARY KEY (idParche)
ALTER TABLE Partida ADD CONSTRAINT PK_Partida PRIMARY KEY (idPartida)
ALTER TABLE Plataforma ADD CONSTRAINT PK_Plataforma PRIMARY KEY (idPlataforma)
ALTER TABLE Practica ADD CONSTRAINT PK_Practica PRIMARY KEY (idPractica)
ALTER TABLE Prestigio ADD CONSTRAINT PK_Prestigio PRIMARY KEY (idPrestigio)
ALTER TABLE Progreso ADD CONSTRAINT PK_Progreso PRIMARY KEY (idProgreso)
ALTER TABLE Proyecto ADD CONSTRAINT PK_Proyecto PRIMARY KEY (idProyecto)
ALTER TABLE Racha ADD CONSTRAINT PK_Racha PRIMARY KEY (idRacha)
ALTER TABLE Soundtrack ADD CONSTRAINT PK_Soundtrack PRIMARY KEY (idSoundtrack)
ALTER TABLE Suscripcion ADD CONSTRAINT PK_Suscripcion PRIMARY KEY (idSuscripcion)
ALTER TABLE Temporada ADD CONSTRAINT PK_Temporada PRIMARY KEY (idTemporada)
ALTER TABLE Tienda ADD CONSTRAINT PK_Tienda PRIMARY KEY (idTienda)
ALTER TABLE Vehiculo ADD CONSTRAINT PK_Vehiculo PRIMARY KEY (idVehiculo)
ALTER TABLE Ventaja ADD CONSTRAINT PK_Ventaja PRIMARY KEY (idVentaja)
ALTER TABLE Versión ADD CONSTRAINT PK_Versión PRIMARY KEY (idVersion)
ALTER TABLE AgenteEscuadron ADD CONSTRAINT PK_AgenteEscuadron PRIMARY KEY (idAgenteEscuadron)
ALTER TABLE AgenteGesto ADD CONSTRAINT PK_AgenteGesto PRIMARY KEY (idAgenteGesto)
ALTER TABLE BarraconVehiculo ADD CONSTRAINT PK_BarraconVehiculo PRIMARY KEY (idBarraconVehiculo)
ALTER TABLE CapituloTemporada ADD CONSTRAINT PK_CapituloTemporada PRIMARY KEY (idCapituloTemporada)
ALTER TABLE DesafioBattlepass ADD CONSTRAINT PK_DesafioBattlepass PRIMARY KEY (idDesafioBattlepass)
ALTER TABLE EscuadronAgente ADD CONSTRAINT PK_EscuadronAgente PRIMARY KEY (idEscuadronAgente)
ALTER TABLE JugadorPlataforma ADD CONSTRAINT PK_JugadorPlataforma PRIMARY KEY (idJugadorPlataforma)
ALTER TABLE MapaTemporada ADD CONSTRAINT PK_MapaTemporada PRIMARY KEY (idMapaTemporada)
ALTER TABLE ClipPartida ADD CONSTRAINT PK_ClipPartida PRIMARY KEY (idClipPartida)

ALTER TABLE Ventaja ADD CONSTRAINT FK_VentajaArmerio FOREIGN KEY (idArmerio) REFERENCES Armerio (idArmerio)
ALTER TABLE Agente ADD CONSTRAINT FK_AgenteActor FOREIGN KEY (idActor) REFERENCES Actor (idActor)
ALTER TABLE Agente ADD CONSTRAINT FK_AgenteBarracon FOREIGN KEY (idBarracon) REFERENCES Barracon (idBarracon)
ALTER TABLE Agente ADD CONSTRAINT FK_AgenteInventario FOREIGN KEY (idInventario) REFERENCES Inventario (idInventario)

ALTER TABLE Camuflaje ADD CONSTRAINT FK_CamuflajeArmerio FOREIGN KEY (idArmerio) REFERENCES Armerio (idArmerio)

ALTER TABLE Clase ADD CONSTRAINT FK_ClaseArmerio FOREIGN KEY (idArmerio) REFERENCES Armerio (idArmerio)
ALTER TABLE Clase ADD CONSTRAINT FK_ClaseJugador FOREIGN KEY (idJugador) REFERENCES Jugador (idJugador)


ALTER TABLE Clasificatoria ADD CONSTRAINT FK_ClasificatoriaProgreso FOREIGN KEY (idProgreso) REFERENCES Progreso (idProgreso)

ALTER TABLE Club ADD CONSTRAINT FK_ClubComunidad FOREIGN KEY (idComunidad) REFERENCES Comunidad (idComunidad)

ALTER TABLE Coalicion ADD CONSTRAINT FK_CoalicionAgente FOREIGN KEY (idAgente) REFERENCES Agente (idAgente)

ALTER TABLE Colaboracion ADD CONSTRAINT FK_ColaboracionExclusiva FOREIGN KEY (idExclusiva) REFERENCES Exclusiva (idExclusiva)

ALTER TABLE Compra ADD CONSTRAINT FK_CompraJugador FOREIGN KEY (idJugador) REFERENCES Jugador (idJugador)

ALTER TABLE Desafio ADD CONSTRAINT FK_DesafioMision FOREIGN KEY (idMision) REFERENCES Mision (idMision)


ALTER TABLE Dlc ADD CONSTRAINT FK_DlcTienda FOREIGN KEY (idTienda) REFERENCES Tienda (idTienda)
ALTER TABLE Dlc ADD CONSTRAINT FK_DlcMapa FOREIGN KEY (idMapa) REFERENCES Mapa (idMapa)

ALTER TABLE Escuadron ADD CONSTRAINT FK_EscuadronAgente FOREIGN KEY (idAgente) REFERENCES Agente (idAgente)
ALTER TABLE Escuadron ADD CONSTRAINT FK_EscuadronModo FOREIGN KEY (idModo) REFERENCES Modo (idModo)
ALTER TABLE Escuadron ADD CONSTRAINT FK_EscuadronPartida FOREIGN KEY (idPartida) REFERENCES Partida (idPartida)

ALTER TABLE Evento ADD CONSTRAINT FK_EventoModo FOREIGN KEY (idModo) REFERENCES Modo (idModo)

ALTER TABLE Exclusiva ADD CONSTRAINT FK_ExclusivaModo FOREIGN KEY (idModo) REFERENCES Modo (idModo)


ALTER TABLE Gesto ADD CONSTRAINT FK_GestoAgente FOREIGN KEY (idAgente) REFERENCES Agente (idAgente)

ALTER TABLE Jugador ADD CONSTRAINT FK_JugadorEmblema FOREIGN KEY (idEmblema) REFERENCES Emblema (idEmblema)
ALTER TABLE Jugador ADD CONSTRAINT FK_JugadorClub FOREIGN KEY (idClub) REFERENCES Club (idClub)
ALTER TABLE Jugador ADD CONSTRAINT FK_JugadorNivel FOREIGN KEY (idNivel) REFERENCES Nivel (idNivel)
ALTER TABLE Jugador ADD CONSTRAINT FK_JugadorFupgrade FOREIGN KEY (idFupgrade) REFERENCES Fupgrade (idFupgrade)
ALTER TABLE Jugador ADD CONSTRAINT FK_JugadorProgreso FOREIGN KEY (idProgreso) REFERENCES Progreso (idProgreso)

ALTER TABLE Mapa ADD CONSTRAINT FK_MapaSoundtrack FOREIGN KEY (idSoundtrack) REFERENCES Soundtrack (idSoundtrack)
ALTER TABLE Loot ADD CONSTRAINT FK_LootMapa FOREIGN KEY (idMapa) REFERENCES Mapa (idMapa)
ALTER TABLE Loot ADD CONSTRAINT FK_LootFupgrade FOREIGN KEY (idFupgrade) REFERENCES Fupgrade (idFupgrade)
ALTER TABLE Moneda ADD CONSTRAINT FK_MonedaJugador FOREIGN KEY (idJugador) REFERENCES Jugador (idJugador)

ALTER TABLE Nivel ADD CONSTRAINT FK_NivelFicha FOREIGN KEY (idFicha) REFERENCES Ficha (idFicha)
ALTER TABLE Nivel ADD CONSTRAINT FK_NivelPrestigio FOREIGN KEY (idPrestigio) REFERENCES Prestigio (idPrestigio)

ALTER TABLE Parche ADD CONSTRAINT FK_ParcheVersion FOREIGN KEY (idVersion) REFERENCES Versión (idVersion)

ALTER TABLE Partida ADD CONSTRAINT FK_PartidaCinematica FOREIGN KEY (idCinematica) REFERENCES Cinematica (idCinematica)
ALTER TABLE Partida ADD CONSTRAINT FK_PartidaPractica FOREIGN KEY (idPractica) REFERENCES Practica (idPractica)

ALTER TABLE Plataforma ADD CONSTRAINT FK_PlataformaConfiguracion FOREIGN KEY (idConfiguracion) REFERENCES Configuracion (idConfiguracion)
ALTER TABLE Plataforma ADD CONSTRAINT FK_PlataformaVersion FOREIGN KEY (idVersion) REFERENCES Versión (idVersion)

ALTER TABLE Proyecto ADD CONSTRAINT FK_ProyectoTienda FOREIGN KEY (idTienda) REFERENCES Tienda (idTienda)

ALTER TABLE Racha ADD CONSTRAINT FK_RachaArmerio FOREIGN KEY (idArmerio) REFERENCES Armerio (idArmerio)

ALTER TABLE Suscripcion ADD CONSTRAINT FK_SuscripcionBattlePass FOREIGN KEY (idBattlePass) REFERENCES BattlePass (idBattlepass)

ALTER TABLE Temporada ADD CONSTRAINT FK_TemporadaBattlepass FOREIGN KEY (idBattlepass) REFERENCES Battlepass (idBattlepass)
ALTER TABLE Temporada ADD CONSTRAINT FK_TemporadaDesarrollador FOREIGN KEY (idDesarrollador) REFERENCES Desarrollador (idDesarrollador)

ALTER TABLE Vehiculo ADD CONSTRAINT FK_VehiculoCamuflaje FOREIGN KEY (idCamuflaje) REFERENCES Camuflaje (idCamuflaje)

--ALTER TABLE Ventaja ADD CONSTRAINT FK_VentajaArmerio FOREIGN KEY (idArmerio) REFERENCES Armerio (idArmerio)

ALTER TABLE AgenteEscuadron ADD CONSTRAINT FK_AgenteEscuadronAgente FOREIGN KEY (idAgente) REFERENCES Agente (idAgente)
ALTER TABLE AgenteEscuadron ADD CONSTRAINT FK_AgenteEscuadronEscuadron FOREIGN KEY (idEscuadron) REFERENCES Escuadron (idEscuadron)

ALTER TABLE AgenteGesto ADD CONSTRAINT FK_AgenteGestoAgente FOREIGN KEY (idAgente) REFERENCES Agente (idAgente)
ALTER TABLE AgenteGesto ADD CONSTRAINT FK_AgenteGestoGesto FOREIGN KEY (idGesto) REFERENCES Gesto (idGesto)

ALTER TABLE BarraconVehiculo ADD CONSTRAINT FK_BarraconVehiculoBarracon FOREIGN KEY (idBarracon) REFERENCES Barracon (idBarracon)
ALTER TABLE BarraconVehiculo ADD CONSTRAINT FK_BarraconVehiculoVehiculo FOREIGN KEY (idVehiculo) REFERENCES Vehiculo (idVehiculo)

ALTER TABLE CapituloTemporada ADD CONSTRAINT FK_CapituloTemporadaCapitulo FOREIGN KEY (idCapitulo) REFERENCES Capitulo (idCapitulo)
ALTER TABLE CapituloTemporada ADD CONSTRAINT FK_CapituloTemporadaTemporada FOREIGN KEY (idTemporada) REFERENCES Temporada (idTemporada)

ALTER TABLE DesafioBattlepass ADD CONSTRAINT FK_DesafioBattlepassDesafio FOREIGN KEY (idDesafio) REFERENCES Desafio (idDesafio)
ALTER TABLE DesafioBattlepass ADD CONSTRAINT FK_DesafioBattlepassBattlepass FOREIGN KEY (idBattlePass) REFERENCES BattlePass (idBattlePass)

ALTER TABLE EscuadronAgente ADD CONSTRAINT FK_EscuadronAgenteEscuadron FOREIGN KEY (idEscuadron) REFERENCES Escuadron (idEscuadron)
ALTER TABLE EscuadronAgente ADD CONSTRAINT FK_EscuadronAgenteAgente FOREIGN KEY (idAgente) REFERENCES Agente (idAgente)

ALTER TABLE JugadorPlataforma ADD CONSTRAINT FK_JugadorPlataformaJugador FOREIGN KEY (idJugador) REFERENCES Jugador (idJugador)
ALTER TABLE JugadorPlataforma ADD CONSTRAINT FK_JugadorPlataformaPlataforma FOREIGN KEY (idPlataforma) REFERENCES Plataforma (idPlataforma)

ALTER TABLE MapaTemporada ADD CONSTRAINT FK_MapaTemporadaMapa FOREIGN KEY (idMapa) REFERENCES Mapa (idMapa)
ALTER TABLE MapaTemporada ADD CONSTRAINT FK_MapaTemporadaTemporada FOREIGN KEY (idTemporada) REFERENCES Temporada (idTemporada)

ALTER TABLE ClipPartida ADD CONSTRAINT FK_ClipPartidaClip FOREIGN KEY (idClip) REFERENCES Clip (idClip)
ALTER TABLE ClipPartida ADD CONSTRAINT FK_ClipPartidaPartida FOREIGN KEY (idPartida) REFERENCES Partida (idPartida)










--Insterts Actor
INSERT INTO	Actor(nombre, fechaNacimiento, tipoDeContrato) VALUES('actor1', '2022/12/04', 'contrato666')
GO
INSERT INTO	Actor(nombre, fechaNacimiento, tipoDeContrato) VALUES('actor2', '2022/12/01', 'contrato5666')
GO
INSERT INTO	Actor(nombre, fechaNacimiento, tipoDeContrato) VALUES('actor3', '2022/12/02', 'contrato5353')
GO
INSERT INTO	Actor(nombre, fechaNacimiento, tipoDeContrato) VALUES('actor14', '2022/12/05', 'contrato533')
GO
INSERT INTO	Actor(nombre, fechaNacimiento, tipoDeContrato) VALUES('actor15', '2022/12/06', 'contrato563')
GO
INSERT INTO	Actor(nombre, fechaNacimiento, tipoDeContrato) VALUES('actor16', '2022/12/07', 'contrato533')
GO
INSERT INTO	Actor(nombre, fechaNacimiento, tipoDeContrato) VALUES('actor17', '2022/12/07', 'contrato424')
GO
INSERT INTO	Actor(nombre, fechaNacimiento, tipoDeContrato) VALUES('actor18', '2022/12/08', 'contrato332')
GO
INSERT INTO	Actor(nombre, fechaNacimiento, tipoDeContrato) VALUES('actor19', '2022/12/09', 'contrato3122')
GO
INSERT INTO	Actor(nombre, fechaNacimiento, tipoDeContrato) VALUES('actor10', '2022/12/12', 'contrato321')
GO

SELECT *FROM Actor
--Inserts Armerio
INSERT INTO	armerio(slot, armas, mejoras) VALUES('slot1', 'ak47', '2022/11/03')
GO
INSERT INTO	armerio(slot, armas, mejoras) VALUES('slot1', 'commando', '2022/11/23')
GO
INSERT INTO	armerio(slot, armas, mejoras) VALUES('slot1', 'vector', '2022/11/21')
GO
INSERT INTO	armerio(slot, armas, mejoras) VALUES('slot1', 'kar', '2022/11/22')
GO
INSERT INTO	armerio(slot, armas, mejoras) VALUES('slot1', 'gallo', '2022/11/23')
GO
INSERT INTO	armerio(slot, armas, mejoras) VALUES('slot1', 'AX50', '2022/11/24')
GO
INSERT INTO	armerio(slot, armas, mejoras) VALUES('slot1', 'Origin', '2022/11/25')
GO
INSERT INTO	armerio(slot, armas, mejoras) VALUES('slot1', 'SPR', '2022/11/26' )
GO
INSERT INTO	armerio(slot, armas, mejoras) VALUES('slot1', 'SUPERNOVA', '2022/11/27')
GO
INSERT INTO	armerio(slot, armas, mejoras) VALUES('slot1', 'Shotgun', '2022/11/29')
GO

select *from armerio
--inserts barracon
INSERT INTO	barracon(tarjetaDeVisita, calidad, precio) VALUES(1, 'rara', '1200')
GO
INSERT INTO	barracon(tarjetaDeVisita, calidad, precio) VALUES(2, 'legendaria', '1500')
GO
INSERT INTO	barracon(tarjetaDeVisita, calidad, precio) VALUES(3, 'rara', '1543')
GO
INSERT INTO	barracon(tarjetaDeVisita, calidad, precio) VALUES(4, 'rara', '1533')
GO
INSERT INTO	barracon(tarjetaDeVisita, calidad, precio) VALUES(6, 'rara', '1642')
GO
INSERT INTO	barracon(tarjetaDeVisita, calidad, precio) VALUES(7, 'rara', '1642')
GO
INSERT INTO	barracon(tarjetaDeVisita, calidad, precio) VALUES(8, 'rara', '1632')
GO
INSERT INTO	barracon(tarjetaDeVisita, calidad, precio) VALUES(9, 'rara', '1642')
GO
INSERT INTO	barracon(tarjetaDeVisita, calidad, precio) VALUES(10, 'rara', '1642')
GO
INSERT INTO	barracon(tarjetaDeVisita, calidad, precio) VALUES(11, 'rara', '1642')
GO

SELECT *FROM barracon
--Inserts battlepass
INSERT INTO	battlepass(nombre, nivelActual, recompensa) VALUES('nombre1', '1', 'skin')
GO
INSERT INTO	battlepass(nombre, nivelActual, recompensa) VALUES('nombre2', '2', 'arma')
GO
INSERT INTO	battlepass(nombre, nivelActual, recompensa) VALUES('nombre3', '3', 'agente')
GO
INSERT INTO	battlepass(nombre, nivelActual, recompensa) VALUES('nombre4', '4', 'skin')
GO
INSERT INTO	battlepass(nombre, nivelActual, recompensa) VALUES('nombre5', '5', 'spray')
GO
INSERT INTO	battlepass(nombre, nivelActual, recompensa) VALUES('nombre6', '6', 'pantalla')
GO
INSERT INTO	battlepass(nombre, nivelActual, recompensa) VALUES('nombre7', '7', 'pase')
GO
INSERT INTO	battlepass(nombre, nivelActual, recompensa) VALUES('nombre8', '8', 'arma')
GO
INSERT INTO	battlepass(nombre, nivelActual, recompensa) VALUES('nombre9', '9', 'accesorio')
GO
INSERT INTO	battlepass(nombre, nivelActual, recompensa) VALUES('nombre10', '10', 'charm')
GO

select *from Battlepass
--Inserts Capitulo

INSERT INTO	capitulo(nombre, juego) VALUES('nombre1', 'bo2')
GO
INSERT INTO	capitulo(nombre, juego) VALUES('nombre2', 'aw')
GO
INSERT INTO	capitulo(nombre, juego) VALUES('nombre3', 'cc')
GO
INSERT INTO	capitulo(nombre, juego) VALUES('nombre4', 'wz')
GO
INSERT INTO	capitulo(nombre, juego) VALUES('nombre5', 'mw')
GO
INSERT INTO	capitulo(nombre, juego) VALUES('nombre6', 'bo1')
GO
INSERT INTO	capitulo(nombre, juego) VALUES('nombre7', 'aw')
GO
INSERT INTO	capitulo(nombre, juego) VALUES('nombre8', 'bo3')
GO
INSERT INTO	capitulo(nombre, juego) VALUES('nombre9', 'sx')
GO
INSERT INTO	capitulo(nombre, juego) VALUES('nombre10', 'ze')
GO
Select *From capitulo
--Inserts Cinematica
INSERT INTO	cinematica(duracion, perteneceAModo, sePuedeSaltar) VALUES('duracion1', 'multi',1)
GO
INSERT INTO	cinematica(duracion, perteneceAModo, sePuedeSaltar) VALUES('duracion1', 'warzone',1)
GO
INSERT INTO	cinematica(duracion, perteneceAModo, sePuedeSaltar) VALUES('duracion1', 'verdansk',1)
GO
INSERT INTO	cinematica(duracion, perteneceAModo, sePuedeSaltar) VALUES('duracion1', 'rebirth',1)
GO
INSERT INTO	cinematica(duracion, perteneceAModo, sePuedeSaltar) VALUES('duracion1', 'tiroteo',1)
GO
INSERT INTO	cinematica(duracion, perteneceAModo, sePuedeSaltar) VALUES('duracion1', 'campaña',1)
GO
INSERT INTO	cinematica(duracion, perteneceAModo, sePuedeSaltar) VALUES('duracion1', 'zombies',1)
GO
INSERT INTO	cinematica(duracion, perteneceAModo,sePuedeSaltar ) VALUES('duracion1', 'extintion',1)
GO
INSERT INTO	cinematica(duracion, perteneceAModo,sePuedeSaltar ) VALUES('duracion1', 'modo9',1)
GO
INSERT INTO	cinematica(duracion, perteneceAModo, sePuedeSaltar) VALUES('duracion1', 'modo10',1)
GO
select *from Cinematica
--Inserts Clip
INSERT INTO	clip(numeroClip, autor, duracion) VALUES('4', 'autor1','2:30')
GO
INSERT INTO	clip(numeroClip, autor, duracion) VALUES('56', 'autor2','5:06')
GO
INSERT INTO	clip(numeroClip, autor, duracion) VALUES('76', 'autor3','23:23')
GO
INSERT INTO	clip(numeroClip, autor, duracion) VALUES('4', 'autor4','1:23:23')
GO
INSERT INTO	clip(numeroClip, autor, duracion) VALUES('4', 'autor5','42:21')
GO
INSERT INTO	clip(numeroClip, autor, duracion) VALUES('78', 'autor6','56:62')
GO
INSERT INTO	clip(numeroClip, autor, duracion) VALUES('56', 'autor7','59:21')
GO
INSERT INTO	clip(numeroClip, autor,duracion ) VALUES('34', 'autor8','12:12')
GO
INSERT INTO	clip(numeroClip, autor,duracion ) VALUES('5', 'autor9','01:29')
GO
INSERT INTO	clip(numeroClip, autor, duracion) VALUES('64', 'autor10','41:21')
GO
select *from clip
--INSERTS COMUNIDAD
INSERT INTO	comunidad(nacionalidad, juego, usuariosConectados) VALUES('juego1', 'juego1','1')
GO
INSERT INTO	comunidad(nacionalidad, juego, usuariosConectados) VALUES('juego2', 'juego2','2')
GO
INSERT INTO	comunidad(nacionalidad, juego, usuariosConectados) VALUES('juego3', 'juego3','3')
GO
INSERT INTO	comunidad(nacionalidad, juego, usuariosConectados) VALUES('juego4', 'juego4','4')
GO
INSERT INTO	comunidad(nacionalidad, juego, usuariosConectados) VALUES('juego5', 'juego5','5')
GO
INSERT INTO	comunidad(nacionalidad, juego, usuariosConectados) VALUES('juego6', 'juego6','46')
GO
INSERT INTO	comunidad(nacionalidad, juego, usuariosConectados) VALUES('juego7', 'juego7','7')
GO
INSERT INTO	comunidad(nacionalidad, juego, usuariosConectados) VALUES('juego8', 'juego8','58')
GO
INSERT INTO	comunidad(nacionalidad, juego,usuariosConectados ) VALUES('juego9', 'juego9','9')
GO
INSERT INTO	comunidad(nacionalidad, juego,usuariosConectados ) VALUES('juego10', 'juego10','0')
GO
select *from comunidad
--INSERTS CLUB
INSERT INTO club(nombre,integrante,plataforma,idComunidad) VALUES('nombre1', 'integrante1', 'plataforma1',1)
GO
INSERT INTO club(nombre,integrante,plataforma,idComunidad) VALUES('nombre2', 'integrante2', 'plataforma2',1)
GO
INSERT INTO club(nombre,integrante,plataforma,idComunidad) VALUES('nombre3', 'integrante3', 'plataforma3',1)
GO
INSERT INTO club(nombre,integrante,plataforma,idComunidad) VALUES('nombre4', 'integrante4', 'plataforma4',1)
GO
INSERT INTO club(nombre,integrante,plataforma,idComunidad) VALUES('nombre5', 'integrante5', 'plataforma5',1)
GO
INSERT INTO club(nombre,integrante,plataforma,idComunidad) VALUES('nombre6', 'integrante6', 'plataforma6',1)
GO
INSERT INTO club(nombre,integrante,plataforma,idComunidad) VALUES('nombre7', 'integrante7', 'plataforma6',1)
GO
INSERT INTO club(nombre,integrante,plataforma,idComunidad) VALUES('nombre8', 'integrante8', 'plataforma8',1)
GO
INSERT INTO club(nombre,integrante,plataforma,idComunidad) VALUES('nombre9', 'integrante9', 'plataforma9',1)
GO
INSERT INTO club(nombre,integrante,plataforma,idComunidad) VALUES('nombre10', 'integrante10', 'plataforma10',1)
GO

select *from club


--Inserts Configuracion
INSERT INTO configuracion(nivelDeBrillo,sensibilidad,idioma) VALUES('nivelDeBrillo1', 'sensibilidad1', 'idioma1')
GO
INSERT INTO configuracion(nivelDeBrillo,sensibilidad,idioma) VALUES('nivelDeBrillo2', 'sensibilidad2', 'idioma2')
GO
INSERT INTO configuracion(nivelDeBrillo,sensibilidad,idioma) VALUES('nivelDeBrillo3', 'sensibilidad3', 'idioma3')
GO
INSERT INTO configuracion(nivelDeBrillo,sensibilidad,idioma) VALUES('nivelDeBrillo4', 'sensibilidad4', 'idioma4')
GO
INSERT INTO configuracion(nivelDeBrillo,sensibilidad,idioma) VALUES('nivelDeBrillo5', 'sensibilidad5', 'idioma5')
GO
INSERT INTO configuracion(nivelDeBrillo,sensibilidad,idioma) VALUES('nivelDeBrillo6', 'sensibilidad6', 'idioma6')
GO
INSERT INTO configuracion(nivelDeBrillo,sensibilidad,idioma) VALUES('nivelDeBrillo7', 'sensibilidad7', 'idioma6')
GO
INSERT INTO configuracion(nivelDeBrillo,sensibilidad,idioma) VALUES('nivelDeBrillo8', 'sensibilidad8', 'idioma8')
GO
INSERT INTO configuracion(nivelDeBrillo,sensibilidad,idioma) VALUES('nivelDeBrillo9', 'sensibilidad9', 'idioma9')
GO
INSERT INTO configuracion(nivelDeBrillo,sensibilidad,idioma) VALUES('nivelDeBrillo10', 'sensibilidad10', 'idioma10')
GO
select *from Configuracion
--Inserts Desarrollador
INSERT INTO desarrollador(nombre,telefono) VALUES(1, 'telefono1')
GO
INSERT INTO desarrollador(nombre,telefono) VALUES(2, 'telefono2')
GO
INSERT INTO desarrollador(nombre,telefono) VALUES(3, 'telefono3')
GO
INSERT INTO desarrollador(nombre,telefono) VALUES(4, 'telefono4')
GO
INSERT INTO desarrollador(nombre,telefono) VALUES(5, 'telefono5')
GO
INSERT INTO desarrollador(nombre,telefono) VALUES(6, 'telefono6')
GO
INSERT INTO desarrollador(nombre,telefono) VALUES(7, 'telefono7')
GO
INSERT INTO desarrollador(nombre,telefono) VALUES(7, 'telefono8')
GO
INSERT INTO desarrollador(nombre,telefono) VALUES(8, 'telefono9')
GO
INSERT INTO desarrollador(nombre,telefono) VALUES(9, 'telefono10')
GO

select *from desarrollador
--INSERTS EMBLEMA
INSERT INTO emblema(color,tamaño,figura) VALUES('color1', 'tamaño1', 'figura1')
GO
INSERT INTO emblema(color,tamaño,figura) VALUES('color2', 'tamaño2', 'figura2')
GO
INSERT INTO emblema(color,tamaño,figura) VALUES('color3', 'tamaño3', 'figura3')
GO
INSERT INTO emblema(color,tamaño,figura) VALUES('color4', 'tamaño4', 'figura4')
GO
INSERT INTO emblema(color,tamaño,figura) VALUES('color5', 'tamaño5', 'figura5')
GO
INSERT INTO emblema(color,tamaño,figura) VALUES('color6', 'tamaño6', 'figura6')
GO
INSERT INTO emblema(color,tamaño,figura) VALUES('color7', 'tamaño7', 'figura6')
GO
INSERT INTO emblema(color,tamaño,figura) VALUES('color8', 'tamaño8', 'figura8')
GO
INSERT INTO emblema(color,tamaño,figura) VALUES('color9', 'tamaño9', 'figura9')
GO
INSERT INTO emblema(color,tamaño,figura) VALUES('color10', 'tamaño10', 'figura10')
GO
select *from emblema
--Inserts Ficha
INSERT INTO ficha(duracion,valor,potencia) VALUES('12', '1', 'potencia1')
GO
INSERT INTO ficha(duracion,valor,potencia) VALUES('13', '2', 'potencia2')
GO
INSERT INTO ficha(duracion,valor,potencia) VALUES('1', '3', 'potencia3')
GO
INSERT INTO ficha(duracion,valor,potencia) VALUES('2', '4', 'potencia4')
GO
INSERT INTO ficha(duracion,valor,potencia) VALUES('3', '5', 'potencia5')
GO
INSERT INTO ficha(duracion,valor,potencia) VALUES('4', '6', 'potencia6')
GO
INSERT INTO ficha(duracion,valor,potencia) VALUES('5', '7', 'potencia6')
GO
INSERT INTO ficha(duracion,valor,potencia) VALUES('6', '8', 'potencia8')
GO
INSERT INTO ficha(duracion,valor,potencia) VALUES('7', '9', 'potencia9')
GO
INSERT INTO ficha(duracion,valor,potencia) VALUES('8', '10', 'potencia10')
GO
select *from ficha
--Fupgrade
INSERT INTO fupgrade(duracion,nombre,killNecesarias) VALUES('d1', 'nombre1', 'k6')
GO
INSERT INTO fupgrade(duracion,nombre,killNecesarias) VALUES('d2', 'nombre2', 'k5')
GO
INSERT INTO fupgrade(duracion,nombre,killNecesarias) VALUES('d3', 'nombre3', 'k4')
GO
INSERT INTO fupgrade(duracion,nombre,killNecesarias) VALUES('d4', 'nombre4', 'k2')
GO
INSERT INTO fupgrade(duracion,nombre,killNecesarias) VALUES('d5', 'nombre5', 'k2')
GO
INSERT INTO fupgrade(duracion,nombre,killNecesarias) VALUES('d6', 'nombre6', 'k1')
GO
INSERT INTO fupgrade(duracion,nombre,killNecesarias) VALUES('d4', 'nombre7', 'k7')
GO
INSERT INTO fupgrade(duracion,nombre,killNecesarias) VALUES('d3', 'nombre8', 'k8')
GO
INSERT INTO fupgrade(duracion,nombre,killNecesarias) VALUES('d2', 'nombre9', 'k9')
GO
INSERT INTO fupgrade(duracion,nombre,killNecesarias) VALUES('d1', 'nombre10', 'k5')
GO
select *from fupgrade
--INSERTS INVENTARIO
INSERT INTO inventario(calidad,objeto,cantidad) VALUES('calidad1', 'objeto1', 'cantidad1')
GO
INSERT INTO inventario(calidad,objeto,cantidad) VALUES('calidad2', 'objeto2', 'cantidad2')
GO
INSERT INTO inventario(calidad,objeto,cantidad) VALUES('calidad3', 'objeto3', 'cantidad3')
GO
INSERT INTO inventario(calidad,objeto,cantidad) VALUES('calidad4', 'objeto4', 'cantidad4')
GO
INSERT INTO inventario(calidad,objeto,cantidad) VALUES('calidad5', 'objeto5', 'cantidad5')
GO
INSERT INTO inventario(calidad,objeto,cantidad) VALUES('calidad6', 'objeto6', 'cantidad6')
GO
INSERT INTO inventario(calidad,objeto,cantidad) VALUES('calidad7', 'objeto7', 'cantidad6')
GO
INSERT INTO inventario(calidad,objeto,cantidad) VALUES('calidad8', 'objeto8', 'cantidad8')
GO
INSERT INTO inventario(calidad,objeto,cantidad) VALUES('calidad9', 'objeto9', 'cantidad9')
GO
INSERT INTO inventario(calidad,objeto,cantidad) VALUES('calidad10', 'objeto10', 'cantidad10')
GO
select *from inventario
--Inserts Prestigio
INSERT INTO Prestigio(nombre,nivelPrestigio,prestigioAnterior) VALUES('nombre1', 1, 1)
GO
INSERT INTO Prestigio(nombre,nivelPrestigio,prestigioAnterior) VALUES('nombre2', 2, 2)
GO
INSERT INTO Prestigio(nombre,nivelPrestigio,prestigioAnterior) VALUES('nombre3', 3, 3)
GO
INSERT INTO Prestigio(nombre,nivelPrestigio,prestigioAnterior) VALUES('nombre4', 4, 4)
GO
INSERT INTO Prestigio(nombre,nivelPrestigio,prestigioAnterior) VALUES('nombre5', 5, 5)
GO
INSERT INTO Prestigio(nombre,nivelPrestigio,prestigioAnterior) VALUES('nombre6', 6, 6)
GO
INSERT INTO Prestigio(nombre,nivelPrestigio,prestigioAnterior) VALUES('nombre7', 7, 6)
GO
INSERT INTO Prestigio(nombre,nivelPrestigio,prestigioAnterior) VALUES('nombre8', 8, 8)
GO
INSERT INTO Prestigio(nombre,nivelPrestigio,prestigioAnterior) VALUES('nombre9', 9, 9)
GO
INSERT INTO Prestigio(nombre,nivelPrestigio,prestigioAnterior) VALUES('nombre10', 10, 10)
GO
select *from Prestigio
--INSERTS NIVEL
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('nombre1', 1, 1,1,1)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('nombre2', 1, 2,2,2)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('nombre3', 1, 3,3,3)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('nombre4', 1, 4,4,4)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('nombre5', 1, 5,5,5)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('nombre6', 1, 6,6,6)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('nombre7', 1, 6,7,7)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('nombre8', 1, 6,8,8)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('nombre9', 1, 6,9,9)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('nombre10', 1, 6,10,10)
GO
select *from nivel
--INSERTS PROGRESO
INSERT INTO progreso(misionesCompletadas,mejorPuntuacion,rangoAnterior) VALUES('misionesCompletadas1',231, 32)
GO
INSERT INTO progreso(misionesCompletadas,mejorPuntuacion,rangoAnterior) VALUES('misionesCompletadas2', 532, 21)
GO
INSERT INTO progreso(misionesCompletadas,mejorPuntuacion,rangoAnterior) VALUES('misionesCompletadas3', 123, 31)
GO
INSERT INTO progreso(misionesCompletadas,mejorPuntuacion,rangoAnterior) VALUES('misionesCompletadas4', 31, 23)
GO
INSERT INTO progreso(misionesCompletadas,mejorPuntuacion,rangoAnterior) VALUES('misionesCompletadas5', 34, 21)
GO
INSERT INTO progreso(misionesCompletadas,mejorPuntuacion,rangoAnterior) VALUES('misionesCompletadas6', 4, 23)
GO
INSERT INTO progreso(misionesCompletadas,mejorPuntuacion,rangoAnterior) VALUES('misionesCompletadas7', 3, 12)
GO
INSERT INTO progreso(misionesCompletadas,mejorPuntuacion,rangoAnterior) VALUES('misionesCompletadas8', 2, 521)
GO
INSERT INTO progreso(misionesCompletadas,mejorPuntuacion,rangoAnterior) VALUES('misionesCompletadas9', 1, 123)
GO
INSERT INTO progreso(misionesCompletadas,mejorPuntuacion,rangoAnterior) VALUES('misionesCompletadas10', 1, 421)
GO
select *from progreso
--INSERTS jugador 1
INSERT INTO jugador(nombre,fechaCreacion,privilegios,idEmblema,idClub,idNivel,idFupgrade,idProgreso) VALUES('nombre1', '12/12/2002', 'privilegios1',1,1,1,1,1)
GO
INSERT INTO jugador(nombre,fechaCreacion,privilegios,idEmblema,idClub,idNivel,idFupgrade,idProgreso) VALUES('nombre2', '12/12/2002', 'privilegios2',2,2,2,2,2)
GO
INSERT INTO jugador(nombre,fechaCreacion,privilegios,idEmblema,idClub,idNivel,idFupgrade,idProgreso) VALUES('nombre3', '12/12/2002', 'privilegios3',3,3,3,3,3)
GO
INSERT INTO jugador(nombre,fechaCreacion,privilegios,idEmblema,idClub,idNivel,idFupgrade,idProgreso) VALUES('nombre4', '12/12/2002', 'privilegios4',4,4,4,4,4)
GO
INSERT INTO jugador(nombre,fechaCreacion,privilegios,idEmblema,idClub,idNivel,idFupgrade,idProgreso) VALUES('nombre5', '12/12/2002', 'privilegios5',5,5,5,5,5)
GO
INSERT INTO jugador(nombre,fechaCreacion,privilegios,idEmblema,idClub,idNivel,idFupgrade,idProgreso) VALUES('nombre6', '12/12/2002', 'privilegios6',6,6,6,6,6)
GO
INSERT INTO jugador(nombre,fechaCreacion,privilegios,idEmblema,idClub,idNivel,idFupgrade,idProgreso) VALUES('nombre7', '12/12/2002', 'privilegios6',7,7,7,7,7)
GO
INSERT INTO jugador(nombre,fechaCreacion,privilegios,idEmblema,idClub,idNivel,idFupgrade,idProgreso) VALUES('nombre8', '12/12/2002', 'privilegios8',8,8,8,8,8)
GO
INSERT INTO jugador(nombre,fechaCreacion,privilegios,idEmblema,idClub,idNivel,idFupgrade,idProgreso) VALUES('nombre9', '12/12/2002', 'privilegios9',9,9,9,9,9)
GO
INSERT INTO jugador(nombre,fechaCreacion,privilegios,idEmblema,idClub,idNivel,idFupgrade,idProgreso) VALUES('nombre10', '12/12/2002', 'privilegios10',10,10,10,10,10)
GO
select *from jugador
--INSERT MISION
INSERT INTO mision(nombre,jugabilidad,duracion) VALUES('nombre1', 1, 12)
GO
INSERT INTO mision(nombre,jugabilidad,duracion) VALUES('nombre2', 2, 14)
GO
INSERT INTO mision(nombre,jugabilidad,duracion) VALUES('nombre3', 4, 166)
GO
INSERT INTO mision(nombre,jugabilidad,duracion) VALUES('nombre4', 3, 212)
GO
INSERT INTO mision(nombre,jugabilidad,duracion) VALUES('nombre5', 5, 53)
GO
INSERT INTO mision(nombre,jugabilidad,duracion) VALUES('nombre6', 6, 321)
GO
INSERT INTO mision(nombre,jugabilidad,duracion) VALUES('nombre7', 7, 321)
GO
INSERT INTO mision(nombre,jugabilidad,duracion) VALUES('nombre8', 8, 321)
GO
INSERT INTO mision(nombre,jugabilidad,duracion) VALUES('nombre9', 9, 21)
GO
INSERT INTO mision(nombre,jugabilidad,duracion) VALUES('nombre10', 10, 32)
GO
select *from mision
--INSERT MODO
INSERT INTO modo(jugadoresNecesarios,tamaño,duracion) VALUES(1, 'tamaño1', 'duracion1')
GO
INSERT INTO modo(jugadoresNecesarios,tamaño,duracion) VALUES(50, 'tamaño2', 'duracion2')
GO
INSERT INTO modo(jugadoresNecesarios,tamaño,duracion) VALUES(40, 'tamaño3', 'duracion3')
GO
INSERT INTO modo(jugadoresNecesarios,tamaño,duracion) VALUES(67, 'tamaño4', 'duracion4')
GO
INSERT INTO modo(jugadoresNecesarios,tamaño,duracion) VALUES(67, 'tamaño5', 'duracion5')
GO
INSERT INTO modo(jugadoresNecesarios,tamaño,duracion) VALUES(56, 'tamaño6', 'duracion6')
GO
INSERT INTO modo(jugadoresNecesarios,tamaño,duracion) VALUES(45, 'tamaño7', 'duracion6')
GO
INSERT INTO modo(jugadoresNecesarios,tamaño,duracion) VALUES(34, 'tamaño8', 'duracion8')
GO
INSERT INTO modo(jugadoresNecesarios,tamaño,duracion) VALUES(23, 'tamaño9', 'duracion9')
GO
INSERT INTO modo(jugadoresNecesarios,tamaño,duracion) VALUES(43, 'tamaño10', 'duracion10')
GO
select *from modo




--INSERTS PRACTICA
INSERT INTO practica(stage,dificultadPractica) VALUES('stage1', 2)
GO
INSERT INTO practica(stage,dificultadPractica) VALUES('stage2', 4)
GO
INSERT INTO practica(stage,dificultadPractica) VALUES('stage3', 5)
GO
INSERT INTO practica(stage,dificultadPractica) VALUES('stage4', 21)
GO
INSERT INTO practica(stage,dificultadPractica) VALUES('stage5', 21)
GO
INSERT INTO practica(stage,dificultadPractica) VALUES('stage6', 42)
GO
INSERT INTO practica(stage,dificultadPractica) VALUES('stage7', 42)
GO
INSERT INTO practica(stage,dificultadPractica) VALUES('stage8', 42)
GO
INSERT INTO practica(stage,dificultadPractica) VALUES('stage9', 21)
GO
INSERT INTO practica(stage,dificultadPractica) VALUES('stage10', 21)
GO
select *from practica


--INSERT SOUNDTRACK
INSERT INTO soundtrack(autor,nombre,duracion) VALUES('autor1', 'nombre1', 'duracion1')
GO
INSERT INTO soundtrack(autor,nombre,duracion) VALUES('autor2', 'nombre2', 'duracion2')
GO
INSERT INTO soundtrack(autor,nombre,duracion) VALUES('autor3', 'nombre3', 'duracion3')
GO
INSERT INTO soundtrack(autor,nombre,duracion) VALUES('autor4', 'nombre4', 'duracion4')
GO
INSERT INTO soundtrack(autor,nombre,duracion) VALUES('autor5', 'nombre5', 'duracion5')
GO
INSERT INTO soundtrack(autor,nombre,duracion) VALUES('autor6', 'nombre6', 'duracion6')
GO
INSERT INTO soundtrack(autor,nombre,duracion) VALUES('autor7', 'nombre7', 'duracion6')
GO
INSERT INTO soundtrack(autor,nombre,duracion) VALUES('autor8', 'nombre8', 'duracion8')
GO
INSERT INTO soundtrack(autor,nombre,duracion) VALUES('autor9', 'nombre9', 'duracion9')
GO
INSERT INTO soundtrack(autor,nombre,duracion) VALUES('autor10', 'nombre10', 'duracion10')
GO
select *from soundtrack
--INSERTS TIENDA
INSERT INTO tienda(producto,ofertas,precio) VALUES('producto1', 'oferta1', 1)
GO
INSERT INTO tienda(producto,ofertas,precio) VALUES('producto2', 'oferta2', 2)
GO
INSERT INTO tienda(producto,ofertas,precio) VALUES('producto3', 'oferta3', 2)
GO
INSERT INTO tienda(producto,ofertas,precio) VALUES('producto4', 'oferta4', 3)
GO
INSERT INTO tienda(producto,ofertas,precio) VALUES('producto5', 'oferta5', 21)
GO
INSERT INTO tienda(producto,ofertas,precio) VALUES('producto6', 'oferta6', 3)
GO
INSERT INTO tienda(producto,ofertas,precio) VALUES('producto7', 'oferta7', 2)
GO
INSERT INTO tienda(producto,ofertas,precio) VALUES('producto8', 'oferta8', 31)
GO
INSERT INTO tienda(producto,ofertas,precio) VALUES('producto9', 'oferta9', 32)
GO
INSERT INTO tienda(producto,ofertas,precio) VALUES('producto10', 'oferta10', 12)
GO
select *from tienda
--INSERTS VERSION
INSERT INTO versión(cambios,juegoAlQuePertenece) VALUES('cambios1', 'juegoAlQuePertenece1')
GO
INSERT INTO versión(cambios,juegoAlQuePertenece) VALUES('cambios2', 'juegoAlQuePertenece2')
GO
INSERT INTO versión(cambios,juegoAlQuePertenece) VALUES('cambios3', 'juegoAlQuePertenece3')
GO
INSERT INTO versión(cambios,juegoAlQuePertenece) VALUES('cambios4', 'juegoAlQuePertenece4')
GO
INSERT INTO versión(cambios,juegoAlQuePertenece) VALUES('cambios5', 'juegoAlQuePertenece5')
GO
INSERT INTO versión(cambios,juegoAlQuePertenece) VALUES('cambios6', 'juegoAlQuePertenece6')
GO
INSERT INTO versión(cambios,juegoAlQuePertenece) VALUES('cambios7', 'juegoAlQuePertenece7')
GO
INSERT INTO versión(cambios,juegoAlQuePertenece) VALUES('cambios8', 'juegoAlQuePertenece8')
GO
INSERT INTO versión(cambios,juegoAlQuePertenece) VALUES('cambios9', 'juegoAlQuePertenece9' )
GO
INSERT INTO versión(cambios,juegoAlQuePertenece) VALUES('cambios10', 'juegoAlQuePertenece10' )
GO
select *from versión
--INSERTS VERSION
INSERT INTO agente(nombre,edad,nacionalidad,idActor,idBarracon,idInventario) VALUES('nombre1', 1, 'nacionalidad1',1,1,1)
GO
INSERT INTO agente(nombre,edad,nacionalidad,idActor,idBarracon,idInventario) VALUES('nombre1', 1, 'nacionalidad1',2,2,2)
GO
INSERT INTO agente(nombre,edad,nacionalidad,idActor,idBarracon,idInventario) VALUES('nombre1', 1, 'nacionalidad1',3,3,3)
GO
INSERT INTO agente(nombre,edad,nacionalidad,idActor,idBarracon,idInventario) VALUES('nombre1', 1, 'nacionalidad1',4,4,4)
GO
INSERT INTO agente(nombre,edad,nacionalidad,idActor,idBarracon,idInventario) VALUES('nombre1', 1, 'nacionalidad1',5,5,5)
GO
INSERT INTO agente(nombre,edad,nacionalidad,idActor,idBarracon,idInventario) VALUES('nombre1', 1, 'nacionalidad1',6,6,6)
GO
INSERT INTO agente(nombre,edad,nacionalidad,idActor,idBarracon,idInventario) VALUES('nombre1', 1, 'nacionalidad1',7,7,7)
GO
INSERT INTO agente(nombre,edad,nacionalidad,idActor,idBarracon,idInventario) VALUES('nombre1', 1, 'nacionalidad1',8,8,8)
GO
INSERT INTO agente(nombre,edad,nacionalidad,idActor,idBarracon,idInventario) VALUES('nombre1', 1, 'nacionalidad1',9,9,9)
GO
INSERT INTO agente(nombre,edad,nacionalidad,idActor,idBarracon,idInventario) VALUES('nombre1', 1, 'nacionalidad1',10,10,10)
GO
select *from agente

--INSERTS camuflaje
INSERT INTO camuflaje(color,precio,tieneAnimacion,idArmerio) VALUES('color1', 1, 1,1)
GO
INSERT INTO camuflaje(color,precio,tieneAnimacion,idArmerio) VALUES('nombre2', 2, 1,2)
GO
INSERT INTO camuflaje(color,precio,tieneAnimacion,idArmerio) VALUES('nombre3', 3, 1,3)
GO
INSERT INTO camuflaje(color,precio,tieneAnimacion,idArmerio) VALUES('nombre4', 4, 1,4)
GO
INSERT INTO camuflaje(color,precio,tieneAnimacion,idArmerio) VALUES('nombre5', 5, 1,5)
GO
INSERT INTO camuflaje(color,precio,tieneAnimacion,idArmerio) VALUES('nombre6', 5, 1,6)
GO
INSERT INTO camuflaje(color,precio,tieneAnimacion,idArmerio) VALUES('nombre7', 6, 1,7)
GO
INSERT INTO camuflaje(color,precio,tieneAnimacion,idArmerio) VALUES('nombre8', 7, 1,8)
GO
INSERT INTO camuflaje(color,precio,tieneAnimacion,idArmerio) VALUES('nombre9', 1, 8,9)
GO
INSERT INTO camuflaje(color,precio,tieneAnimacion,idArmerio) VALUES('nombre10', 1, 9,10)
GO
select *from camuflaje
--INSERTS Clase
INSERT INTO clase(slot,armaPrincipal,armaSecundaria,idArmerio,idJugador) VALUES(1,'armaPrincipal1','armaPrincipal1',  1,1)
GO
INSERT INTO clase(slot,armaPrincipal,armaSecundaria,idArmerio,idJugador) VALUES(2,'armaPrincipal2','armaPrincipal2',  2,2)
GO
INSERT INTO clase(slot,armaPrincipal,armaSecundaria,idArmerio,idJugador) VALUES(3,'armaPrincipal3','armaPrincipal4',  3,3)
GO
INSERT INTO clase(slot,armaPrincipal,armaSecundaria,idArmerio,idJugador) VALUES(4,'armaPrincipal4','armaPrincipal5',  4,4)
GO
INSERT INTO clase(slot,armaPrincipal,armaSecundaria,idArmerio,idJugador) VALUES(5,'armaPrincipal5','armaPrincipal6',  5,5)
GO
INSERT INTO clase(slot,armaPrincipal,armaSecundaria,idArmerio,idJugador) VALUES(6,'armaPrincipal6','armaPrincipal7',  7,6)
GO
INSERT INTO clase(slot,armaPrincipal,armaSecundaria,idArmerio,idJugador) VALUES(7,'armaPrincipal7','armaPrincipal8',  8,7)
GO
INSERT INTO clase(slot,armaPrincipal,armaSecundaria,idArmerio,idJugador) VALUES(8,'armaPrincipal19','armaPrincipal9',  9,8)
GO
INSERT INTO clase(slot,armaPrincipal,armaSecundaria,idArmerio,idJugador) VALUES(9,'armaPrincipal10','armaPrincipal10', 10,9)
GO
--INSERTS CLASIFICATORIA
INSERT INTO clasificatoria(rangoNecesario,puedeRankear,rangoActual,idProgreso) VALUES('nombre1', 1, 'oro', 1)
GO
INSERT INTO clasificatoria(rangoNecesario,puedeRankear,rangoActual,idProgreso) VALUES('nombre2', 1, 'oro', 2)
GO
INSERT INTO clasificatoria(rangoNecesario,puedeRankear,rangoActual,idProgreso) VALUES('nombre3', 1, 'oro', 3)
GO
INSERT INTO clasificatoria(rangoNecesario,puedeRankear,rangoActual,idProgreso) VALUES('nombre4', 1,'oro', 4)
GO
INSERT INTO clasificatoria(rangoNecesario,puedeRankear,rangoActual,idProgreso) VALUES('nombre5', 1, 'oro', 5)
GO
INSERT INTO clasificatoria(rangoNecesario,puedeRankear,rangoActual,idProgreso) VALUES('nombre6', 1, 'oro', 6)
GO
INSERT INTO clasificatoria(rangoNecesario,puedeRankear,rangoActual,idProgreso) VALUES('nombre7', 1, 'oro', 7)
GO
INSERT INTO clasificatoria(rangoNecesario,puedeRankear,rangoActual,idProgreso) VALUES('nombre8', 1, 'oro', 8)
GO
INSERT INTO clasificatoria(rangoNecesario,puedeRankear,rangoActual,idProgreso) VALUES('nombre9', 1, 'oro', 9)
GO
INSERT INTO clasificatoria(rangoNecesario,puedeRankear,rangoActual,idProgreso) VALUES('nombre10', 1, 'oro', 10)
GO
select *from Clasificatoria
--INSERT coalicion
INSERT INTO coalicion(nombre,cantidadIntegrentes,paisOrigen,idAgente) VALUES('nombre1', '1', 'oro', 1)
GO
INSERT INTO coalicion(nombre,cantidadIntegrentes,paisOrigen,idAgente) VALUES('nombre2', '1', 'oro', 2)
GO
INSERT INTO coalicion(nombre,cantidadIntegrentes,paisOrigen,idAgente) VALUES('nombre3', '1', 'oro', 3)
GO
INSERT INTO coalicion(nombre,cantidadIntegrentes,paisOrigen,idAgente) VALUES('nombre4', '1','oro', 4)
GO
INSERT INTO coalicion(nombre,cantidadIntegrentes,paisOrigen,idAgente) VALUES('nombre5', '1', 'oro', 5)
GO
INSERT INTO coalicion(nombre,cantidadIntegrentes,paisOrigen,idAgente) VALUES('nombre6', '1', 'oro', 6)
GO
INSERT INTO coalicion(nombre,cantidadIntegrentes,paisOrigen,idAgente) VALUES('nombre7', '1', 'oro', 7)
GO
INSERT INTO coalicion(nombre,cantidadIntegrentes,paisOrigen,idAgente) VALUES('nombre8', '1', 'oro', 8)
GO
INSERT INTO coalicion(nombre,cantidadIntegrentes,paisOrigen,idAgente) VALUES('nombre9', '1', 'oro', 9)
GO
INSERT INTO coalicion(nombre,cantidadIntegrentes,paisOrigen,idAgente) VALUES('nombre10', '1', 'oro', 10)
GO

--INSERTS EXCLUSIVA
INSERT INTO exclusiva(contenido,plataforma,fechaInicio,idModo) VALUES('contenido1', 'plataforma1', '05/12/2001',8)
GO
INSERT INTO exclusiva(contenido,plataforma,fechaInicio,idModo) VALUES('contenido2', 'plataforma2', '05/12/2001',1)
GO
INSERT INTO exclusiva(contenido,plataforma,fechaInicio,idModo) VALUES('contenido3', 'plataforma3', '05/12/2001',2)
GO
INSERT INTO exclusiva(contenido,plataforma,fechaInicio,idModo) VALUES('contenido4', 'plataforma4', '05/12/2001',3)
GO
INSERT INTO exclusiva(contenido,plataforma,fechaInicio,idModo) VALUES('contenido5', 'plataforma5', '05/12/2001',4)
GO
INSERT INTO exclusiva(contenido,plataforma,fechaInicio,idModo) VALUES('contenido6', 'plataforma6', '05/12/2001',5)
GO
INSERT INTO exclusiva(contenido,plataforma,fechaInicio,idModo) VALUES('contenido7', 'plataforma7', '05/12/2001',6)
GO
INSERT INTO exclusiva(contenido,plataforma,fechaInicio,idModo) VALUES('contenido8', 'plataforma8', '05/12/2001',7)
GO
INSERT INTO exclusiva(contenido,plataforma,fechaInicio,idModo) VALUES('contenido9', 'plataforma9', '05/12/2001',9)
GO
INSERT INTO exclusiva(contenido,plataforma,fechaInicio,idModo) VALUES('contenido10', 'plataforma10', '05/12/2001',10)
GO
select *from exclusiva
--INSERTS COLABORACION
INSERT INTO colaboracion(nombre,inicioColaboracion,finColaboracion,idExclusiva) VALUES('nombre1', '12/01/1932', '12/01/1989', 1)
GO
INSERT INTO colaboracion(nombre,inicioColaboracion,finColaboracion,idExclusiva) VALUES('nombre2', '12/01/1932', '12/01/1989', 2)
GO
INSERT INTO colaboracion(nombre,inicioColaboracion,finColaboracion,idExclusiva) VALUES('nombre3', '12/01/1912', '12/01/1989', 3)
GO
INSERT INTO colaboracion(nombre,inicioColaboracion,finColaboracion,idExclusiva) VALUES('nombre4', '12/01/1965','12/01/1989', 4)
GO
INSERT INTO colaboracion(nombre,inicioColaboracion,finColaboracion,idExclusiva) VALUES('nombre5', '12/01/1965', '12/01/1989', 5)
GO
INSERT INTO colaboracion(nombre,inicioColaboracion,finColaboracion,idExclusiva) VALUES('nombre6', '12/01/1967', '12/01/1989', 6)
GO
INSERT INTO colaboracion(nombre,inicioColaboracion,finColaboracion,idExclusiva) VALUES('nombre7', '12/01/1900', '12/01/1989', 7)
GO
INSERT INTO colaboracion(nombre,inicioColaboracion,finColaboracion,idExclusiva) VALUES('nombre8', '12/01/1978', '12/01/1989', 8)
GO
INSERT INTO colaboracion(nombre,inicioColaboracion,finColaboracion,idExclusiva) VALUES('nombre9', '12/01/1989', '12/01/1989', 9)
GO
INSERT INTO colaboracion(nombre,inicioColaboracion,finColaboracion,idExclusiva) VALUES('nombre10', '12/01/1989', '12/01/1989', 10)
GO
select *from colaboracion


--INSERTS COMPRA
INSERT INTO compra(precio,comprasRealizadas,devoluciones,idJugador) VALUES(10, 'plataforma1', '05/12/2001',8)
GO
INSERT INTO compra(precio,comprasRealizadas,devoluciones,idJugador) VALUES(9, 'plataforma2', '05/12/2001',1)
GO
INSERT INTO compra(precio,comprasRealizadas,devoluciones,idJugador) VALUES(8, 'plataforma3', '05/12/2001',2)
GO
INSERT INTO compra(precio,comprasRealizadas,devoluciones,idJugador) VALUES(7, 'plataforma4', '05/12/2001',3)
GO
INSERT INTO compra(precio,comprasRealizadas,devoluciones,idJugador) VALUES(6, 'plataforma5', '05/12/2001',4)
GO
INSERT INTO compra(precio,comprasRealizadas,devoluciones,idJugador) VALUES(5, 'plataforma6', '05/12/2001',5)
GO
INSERT INTO compra(precio,comprasRealizadas,devoluciones,idJugador) VALUES(4, 'plataforma7', '05/12/2001',6)
GO
INSERT INTO compra(precio,comprasRealizadas,devoluciones,idJugador) VALUES(3, 'plataforma8', '05/12/2001',7)
GO
INSERT INTO compra(precio,comprasRealizadas,devoluciones,idJugador) VALUES(2, 'plataforma9', '05/12/2001',9)
GO
INSERT INTO compra(precio,comprasRealizadas,devoluciones,idJugador) VALUES(1, 'plataforma10', '05/12/2001',10)
GO
--INSERT DESAFIO
INSERT INTO desafio(nombre,recompensa,nivelNecesario,idMision) VALUES('nombre1', 'plataforma1', '05/12/2001',8)
GO
INSERT INTO desafio(nombre,recompensa,nivelNecesario,idMision) VALUES('nombre1', 'plataforma2', '05/12/2001',1)
GO
INSERT INTO desafio(nombre,recompensa,nivelNecesario,idMision) VALUES('nombre1', 'plataforma3', '05/12/2001',2)
GO
INSERT INTO desafio(nombre,recompensa,nivelNecesario,idMision) VALUES('nombre1', 'plataforma4', '05/12/2001',3)
GO
INSERT INTO desafio(nombre,recompensa,nivelNecesario,idMision) VALUES('nombre1', 'plataforma5', '05/12/2001',4)
GO
INSERT INTO desafio(nombre,recompensa,nivelNecesario,idMision) VALUES('nombre1', 'plataforma6', '05/12/2001',5)
GO
INSERT INTO desafio(nombre,recompensa,nivelNecesario,idMision) VALUES('nombre1', 'plataforma7', '05/12/2001',6)
GO
INSERT INTO desafio(nombre,recompensa,nivelNecesario,idMision) VALUES('nombre1', 'plataforma8', '05/12/2001',7)
GO
INSERT INTO desafio(nombre,recompensa,nivelNecesario,idMision) VALUES('nombre1', 'plataforma9', '05/12/2001',9)
GO
INSERT INTO desafio(nombre,recompensa,nivelNecesario,idMision) VALUES('nombre1', 'plataforma10', '05/12/2001',10)
GO
select *from desafio
--INSERTS MAPA
INSERT INTO mapa(categoria,tamaño,idSoundtrack) VALUES(1, '', 1)
GO
INSERT INTO mapa(categoria,tamaño,idSoundtrack) VALUES(3, '', 2)
GO
INSERT INTO mapa(categoria,tamaño,idSoundtrack) VALUES(2, '', 3)
GO
INSERT INTO mapa(categoria,tamaño,idSoundtrack) VALUES(3, '', 4)
GO
INSERT INTO mapa(categoria,tamaño,idSoundtrack) VALUES(4, '', 5)
GO
INSERT INTO mapa(categoria,tamaño,idSoundtrack) VALUES(5, '', 6)
GO
INSERT INTO mapa(categoria,tamaño,idSoundtrack) VALUES(6, '', 7)
GO
INSERT INTO mapa(categoria,tamaño,idSoundtrack) VALUES(7, '', 8)
GO
INSERT INTO mapa(categoria,tamaño,idSoundtrack) VALUES(8, '', 9)
GO
INSERT INTO mapa(categoria,tamaño,idSoundtrack) VALUES(9, '', 10)
GO
--INSERT DLC
INSERT INTO dlc(precio,nombre,fechaDeSalida,idTienda,idMapa) VALUES(9, 'plataforma1', '05/12/2001',1,1)
GO
INSERT INTO dlc(precio,nombre,fechaDeSalida,idTienda,idMapa) VALUES(9, 'plataforma2', '05/12/2001',2,2)
GO
INSERT INTO dlc(precio,nombre,fechaDeSalida,idTienda,idMapa) VALUES(9, 'plataforma3', '05/12/2001',3,3)
GO
INSERT INTO dlc(precio,nombre,fechaDeSalida,idTienda,idMapa) VALUES(9, 'plataforma4', '05/12/2001',4,4)
GO
INSERT INTO dlc(precio,nombre,fechaDeSalida,idTienda,idMapa) VALUES(6, 'plataforma5', '05/12/2001',5,5)
GO
INSERT INTO dlc(precio,nombre,fechaDeSalida,idTienda,idMapa) VALUES(5, 'plataforma6', '05/12/2001',6,6)
GO
INSERT INTO dlc(precio,nombre,fechaDeSalida,idTienda,idMapa) VALUES(4, 'plataforma7', '05/12/2001',7,7)
GO
INSERT INTO dlc(precio,nombre,fechaDeSalida,idTienda,idMapa) VALUES(3, 'plataforma8', '05/12/2001',8,8)
GO
INSERT INTO dlc(precio,nombre,fechaDeSalida,idTienda,idMapa) VALUES(2, 'plataforma9', '05/12/2001',9,9)
GO
INSERT INTO dlc(precio,nombre,fechaDeSalida,idTienda,idMapa) VALUES(1, 'plataforma10', '05/12/2001',10,10)
GO
select *from dlc
--INSERTS PARTIDA 
INSERT INTO partida(cantidadJugadores,duracion,squadGanador,idCinematica,idPractica) VALUES(1, 'duracion1','squad1', 1,1)
GO
INSERT INTO partida(cantidadJugadores,duracion,squadGanador,idCinematica,idPractica) VALUES(3, 'duracion2','squad12' ,2,2)
GO
INSERT INTO partida(cantidadJugadores,duracion,squadGanador,idCinematica,idPractica) VALUES(2, 'duracion3', 'squad13',3,3)
GO
INSERT INTO partida(cantidadJugadores,duracion,squadGanador,idCinematica,idPractica) VALUES(3, 'duracion4','squad14' ,4,4)
GO
INSERT INTO partida(cantidadJugadores,duracion,squadGanador,idCinematica,idPractica) VALUES(4, 'duracion5', 'squad15',5,5)
GO
INSERT INTO partida(cantidadJugadores,duracion,squadGanador,idCinematica,idPractica) VALUES(5, 'duracion6', 'squad16',6,6)
GO
INSERT INTO partida(cantidadJugadores,duracion,squadGanador,idCinematica,idPractica) VALUES(6, 'duracion7', 'squad17',7,7)
GO
INSERT INTO partida(cantidadJugadores,duracion,squadGanador,idCinematica,idPractica) VALUES(7, 'duracion8', 'squad18',8,8)
GO
INSERT INTO partida(cantidadJugadores,duracion,squadGanador,idCinematica,idPractica) VALUES(8, 'duracion9', 'squad19',9,9)
GO
INSERT INTO partida(cantidadJugadores,duracion,squadGanador,idCinematica,idPractica) VALUES(9, 'duracion10','squad20' ,10,10)
GO
select *from partida

--INSERT ESCUADRON
INSERT INTO escuadron(nombre,integrantes,idAgente,idModo,idPartida) VALUES(1, 'integrantes1', 1,1,1)
GO
INSERT INTO escuadron(nombre,integrantes,idAgente,idModo,idPartida) VALUES(3, 'integrantes2', 2,2,2)
GO
INSERT INTO escuadron(nombre,integrantes,idAgente,idModo,idPartida) VALUES(2, 'integrantes3', 3,3,3)
GO
INSERT INTO escuadron(nombre,integrantes,idAgente,idModo,idPartida) VALUES(3, 'integrantes4', 4,4,4)
GO
INSERT INTO escuadron(nombre,integrantes,idAgente,idModo,idPartida) VALUES(4, 'integrantes5', 5,5,5)
GO
INSERT INTO escuadron(nombre,integrantes,idAgente,idModo,idPartida) VALUES(5, 'integrantes6', 6,6,6)
GO
INSERT INTO escuadron(nombre,integrantes,idAgente,idModo,idPartida) VALUES(6, 'integrantes7', 7,7,7)
GO
INSERT INTO escuadron(nombre,integrantes,idAgente,idModo,idPartida) VALUES(7, 'integrantes8', 8,8,8)
GO
INSERT INTO escuadron(nombre,integrantes,idAgente,idModo,idPartida) VALUES(8, 'integrantes9', 9,9,9)
GO
INSERT INTO escuadron(nombre,integrantes,idAgente,idModo,idPartida) VALUES(9, 'integrantes10', 10,10,10)
GO

select *from escuadron

-- INSERTS EVENTO
INSERT INTO evento(nombre,fechaInicio,fechaFin,idModo) VALUES('nombre1', '', '',1)
GO
INSERT INTO evento(nombre,fechaInicio,fechaFin,idModo) VALUES('nombre2', '', '',2)
GO
INSERT INTO evento(nombre,fechaInicio,fechaFin,idModo) VALUES('nombre3', '', '',3)
GO
INSERT INTO evento(nombre,fechaInicio,fechaFin,idModo) VALUES('nombre4', '', '',4)
GO
INSERT INTO evento(nombre,fechaInicio,fechaFin,idModo) VALUES('nombre5', '', '',5)
GO
INSERT INTO evento(nombre,fechaInicio,fechaFin,idModo) VALUES('nombre6', '', '',6)
GO
INSERT INTO evento(nombre,fechaInicio,fechaFin,idModo) VALUES('nombre7', '', '',7)
GO
INSERT INTO evento(nombre,fechaInicio,fechaFin,idModo) VALUES('nombre8', '', '',8)
GO
INSERT INTO evento(nombre,fechaInicio,fechaFin,idModo) VALUES('nombre9', '', '',9)
GO
INSERT INTO evento(nombre,fechaInicio,fechaFin,idModo) VALUES('nombre10', '', '',10)
GO
select *from evento
--INSERTS GESTO
INSERT INTO gesto(calidad,temporadaSalida,tipo,idAgente) VALUES('calidad1', 'temporadaSalida1', 'tipo1',1)
GO
INSERT INTO gesto(calidad,temporadaSalida,tipo,idAgente) VALUES('calidad2', 'temporadaSalida2', 'tipo2',2)
GO
INSERT INTO gesto(calidad,temporadaSalida,tipo,idAgente) VALUES('calidad3', 'temporadaSalida3', 'tipo3',3)
GO
INSERT INTO gesto(calidad,temporadaSalida,tipo,idAgente) VALUES('calidad4', 'temporadaSalida4', 'tipo4',4)
GO
INSERT INTO gesto(calidad,temporadaSalida,tipo,idAgente) VALUES('calidad5', 'temporadaSalida5', 'tipo5',5)
GO
INSERT INTO gesto(calidad,temporadaSalida,tipo,idAgente) VALUES('calidad6', 'temporadaSalida6', 'tipo6',6)
GO
INSERT INTO gesto(calidad,temporadaSalida,tipo,idAgente) VALUES('calidad7', 'temporadaSalida7', 'tipo6',7)
GO
INSERT INTO gesto(calidad,temporadaSalida,tipo,idAgente) VALUES('calidad8', 'temporadaSalida8', 'tipo8',8)
GO
INSERT INTO gesto(calidad,temporadaSalida,tipo,idAgente) VALUES('calidad9', 'temporadaSalida9', 'tipo9',9)
GO
INSERT INTO gesto(calidad,temporadaSalida,tipo,idAgente) VALUES('calidad10', 'temporadaSalida10', 'tipo10',10)
GO
select *from gesto
--INSERTS MONEDA
INSERT INTO moneda(nombre,precio,idJugador) VALUES('nombre1', 'precio1', 1)
GO
INSERT INTO moneda(nombre,precio,idJugador) VALUES('nombre2', 'precio2', 2)
GO
INSERT INTO moneda(nombre,precio,idJugador) VALUES('nombre3', 'precio3', 3)
GO
INSERT INTO moneda(nombre,precio,idJugador) VALUES('nombre4', 'precio4', 4)
GO
INSERT INTO moneda(nombre,precio,idJugador) VALUES('nombre5', 'precio5', 5)
GO
INSERT INTO moneda(nombre,precio,idJugador) VALUES('nombre6', 'precio6', 6)
GO
INSERT INTO moneda(nombre,precio,idJugador) VALUES('nombre7', 'precio7', 7)
GO
INSERT INTO moneda(nombre,precio,idJugador) VALUES('nombre8', 'precio8', 8)
GO
INSERT INTO moneda(nombre,precio,idJugador) VALUES('nombre9', 'precio9', 9)
GO
INSERT INTO moneda(nombre,precio,idJugador) VALUES('nombre10', 'precio10', 10)
GO
select *from moneda
--INSERTS NIVEL
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('identificador1', 1,2, 1, 1)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('identificador2', 2,2, 2, 2)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('identificador3', 3, 2,3,3)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('identificador4', 32,2, 4, 4)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('identificador5', 12,2, 5, 5)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('identificador6', 32, 2,6,6)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('identificador7', 56,2, 7, 7)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('identificador8', 76, 2,8,8)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('identificador9', 89, 2,9,9)
GO
INSERT INTO nivel(identificador,recompensa,desbloqueo,idFicha,idPrestigio) VALUES('identificador10', 12, 2,10,10)
GO
select *from nivel
--INSERTS PARCHE
INSERT INTO parche(serie,fecha,versión,idVersion) VALUES('serie1','' ,2, 1)
GO
INSERT INTO parche(serie,fecha,versión,idVersion) VALUES('serie2', '',2, 2)
GO
INSERT INTO parche(serie,fecha,versión,idVersion) VALUES('serie3', '', 2,,3)
GO
INSERT INTO parche(serie,fecha,versión,idVersion) VALUES('serie4', '',2, 4)
GO
INSERT INTO parche(serie,fecha,versión,idVersion) VALUES('serie5', '',2, 5)
GO
INSERT INTO parche(serie,fecha,versión,idVersion) VALUES('serie6', '', 2,6)
GO
INSERT INTO parche(serie,fecha,versión,idVersion) VALUES('serie7', '',2, 7)
GO
INSERT INTO parche(serie,fecha,versión,idVersion) VALUES('serie8', '', 2,8)
GO
INSERT INTO parche(serie,fecha,versión,idVersion) VALUES('serie9', '', 2,9)
GO
INSERT INTO parche(serie,fecha,versión,idVersion) VALUES('serie10', '', 2,10)
GO
select *from parche
--INSERT PLATAFORMA
INSERT INTO plataforma(requisitos,nombre,idConfiguracion,idVersion) VALUES('requisitos1', 'nombre1', 1,1)
GO
INSERT INTO plataforma(requisitos,nombre,idConfiguracion,idVersion) VALUES('requisitos2', 'nombre2', 2,2)
GO
INSERT INTO plataforma(requisitos,nombre,idConfiguracion,idVersion) VALUES('requisitos3', 'nombre3', 3,3)
GO
INSERT INTO plataforma(requisitos,nombre,idConfiguracion,idVersion) VALUES('requisitos4', 'nombre4', 4,4)
GO
INSERT INTO plataforma(requisitos,nombre,idConfiguracion,idVersion) VALUES('requisitos5', 'nombre5', 5,5)
GO
INSERT INTO plataforma(requisitos,nombre,idConfiguracion,idVersion) VALUES('requisitos6', 'nombre6', 6,6)
GO
INSERT INTO plataforma(requisitos,nombre,idConfiguracion,idVersion) VALUES('requisitos7', 'nombre7', 7,7)
GO
INSERT INTO plataforma(requisitos,nombre,idConfiguracion,idVersion) VALUES('requisitos8', 'nombre8', 8,8)
GO
INSERT INTO plataforma(requisitos,nombre,idConfiguracion,idVersion) VALUES('requisitos9', 'nombre9', 9,9)
GO
INSERT INTO plataforma(requisitos,nombre,idConfiguracion,idVersion) VALUES('requisitos10', 'nombre10', 10,10)
GO
select *from plataforma
--INSERTS PROYECTO
INSERT INTO proyecto(nombre,arma,precio,idTienda) VALUES('nombre1', 'arma1', 1,1)
GO
INSERT INTO proyecto(nombre,arma,precio,idTienda) VALUES('nombre2', 'arma2', 2,2)
GO
INSERT INTO proyecto(nombre,arma,precio,idTienda) VALUES('nombre3', 'arma3', 3,3)
GO
INSERT INTO proyecto(nombre,arma,precio,idTienda) VALUES('nombre4', 'arma4', 4,4)
GO
INSERT INTO proyecto(nombre,arma,precio,idTienda) VALUES('nombre5', 'arma5', 5,5)
GO
INSERT INTO proyecto(nombre,arma,precio,idTienda) VALUES('nombre6', 'arma6', 6,6)
GO
INSERT INTO proyecto(nombre,arma,precio,idTienda) VALUES('nombre7', 'arma7', 7,7)
GO
INSERT INTO proyecto(nombre,arma,precio,idTienda) VALUES('nombre8', 'arma8', 8,8)
GO
INSERT INTO proyecto(nombre,arma,precio,idTienda) VALUES('nombre9', 'arma9', 9,9)
GO
INSERT INTO proyecto(nombre,arma,precio,idTienda) VALUES('nombre10', 'arma10', 10,10)
GO
select *from proyecto
--INSERTS RACHA
INSERT INTO Racha(puntosNecesaraios,nivelDesbloqueo,idArmerio) VALUES('puntosNecesaraios1', 1, 1)
GO
INSERT INTO Racha(puntosNecesaraios,nivelDesbloqueo,idArmerio) VALUES('puntosNecesaraios2', 2, 2)
GO
INSERT INTO Racha(puntosNecesaraios,nivelDesbloqueo,idArmerio) VALUES('puntosNecesaraios3', 3, 3)
GO
INSERT INTO Racha(puntosNecesaraios,nivelDesbloqueo,idArmerio) VALUES('puntosNecesaraios4', 4, 4)
GO
INSERT INTO Racha(puntosNecesaraios,nivelDesbloqueo,idArmerio) VALUES('puntosNecesaraios5', 5, 5)
GO
INSERT INTO Racha(puntosNecesaraios,nivelDesbloqueo,idArmerio) VALUES('puntosNecesaraios6', 6, 6)
GO
INSERT INTO Racha(puntosNecesaraios,nivelDesbloqueo,idArmerio) VALUES('puntosNecesaraios7', 7, 7)
GO
INSERT INTO Racha(puntosNecesaraios,nivelDesbloqueo,idArmerio) VALUES('puntosNecesaraios8', 8, 8)
GO
INSERT INTO Racha(puntosNecesaraios,nivelDesbloqueo,idArmerio) VALUES('puntosNecesaraios9', 9, 9)
GO
INSERT INTO Racha(puntosNecesaraios,nivelDesbloqueo,idArmerio) VALUES('puntosNecesaraios10', 10, 10)
GO
select *from racha
--INSERTS SUSCRIPCION
INSERT INTO suscripcion(precio,tipo,idBattlePass) VALUES('precio1', 'tipo1', 1)
GO
INSERT INTO suscripcion(precio,tipo,idBattlePass) VALUES('precio2', 'tipo2', 2)
GO
INSERT INTO suscripcion(precio,tipo,idBattlePass) VALUES('precio3', 'tipo3', 3)
GO
INSERT INTO suscripcion(precio,tipo,idBattlePass) VALUES('precio4', 'tipo4',4)
GO
INSERT INTO suscripcion(precio,tipo,idBattlePass) VALUES('precio5', 'tipo5', 5)
GO
INSERT INTO suscripcion(precio,tipo,idBattlePass) VALUES('precio6', 'tipo6', 6)
GO
INSERT INTO suscripcion(precio,tipo,idBattlePass) VALUES('precio7', 'tipo7',7)
GO
INSERT INTO suscripcion(precio,tipo,idBattlePass) VALUES('precio8', 'tipo8', 8)
GO
INSERT INTO suscripcion(precio,tipo,idBattlePass) VALUES('precio9', 'tipo9', 9)
GO
INSERT INTO suscripcion(precio,tipo,idBattlePass) VALUES('precio10', 'tipo10', 10)
GO
select *from suscripcion
--INSERTS temporada
INSERT INTO temporada(nombreTemporada,inicio,final,idBattlePass,idDesarrollador) VALUES('nombreTemporada1', '', '',1,1)
GO
INSERT INTO temporada(nombreTemporada,inicio,final,idBattlePass,idDesarrollador) VALUES('nombreTemporada2', '', '',2,2)
GO
INSERT INTO temporada(nombreTemporada,inicio,final,idBattlePass,idDesarrollador) VALUES('nombreTemporada3', '', '',3,3)
GO
INSERT INTO temporada(nombreTemporada,inicio,final,idBattlePass,idDesarrollador) VALUES('nombreTemporada4', '', '',4,4)
GO
INSERT INTO temporada(nombreTemporada,inicio,final,idBattlePass,idDesarrollador) VALUES('nombreTemporada5', '', '',5,5)
GO
INSERT INTO temporada(nombreTemporada,inicio,final,idBattlePass,idDesarrollador) VALUES('nombreTemporada6', '', '',6,6)
GO
INSERT INTO temporada(nombreTemporada,inicio,final,idBattlePass,idDesarrollador) VALUES('nombreTemporada7', '', '',7,7)
GO
INSERT INTO temporada(nombreTemporada,inicio,final,idBattlePass,idDesarrollador) VALUES('nombreTemporada8', '', '',8,8)
GO
INSERT INTO temporada(nombreTemporada,inicio,final,idBattlePass,idDesarrollador) VALUES('nombreTemporada9', '', '',9,9)
GO
INSERT INTO temporada(nombreTemporada,inicio,final,idBattlePass,idDesarrollador) VALUES('nombreTemporada10', '', '',10,10)
GO
select *from temporada
--INSERTS Vehiculo
INSERT INTO Vehiculo(numeroPasajeros,tieneArtilleria,tipo,idCamuflaje) VALUES(1, 1, 'tipo1',1)
GO
INSERT INTO Vehiculo(numeroPasajeros,tieneArtilleria,tipo,idCamuflaje) VALUES(2, 1, 'tipo2',2)
GO
INSERT INTO Vehiculo(numeroPasajeros,tieneArtilleria,tipo,idCamuflaje) VALUES(3, 1, 'tipo3',3)
GO
INSERT INTO Vehiculo(numeroPasajeros,tieneArtilleria,tipo,idCamuflaje) VALUES(4, 1, 'tipo4',4)
GO
INSERT INTO Vehiculo(numeroPasajeros,tieneArtilleria,tipo,idCamuflaje) VALUES(5, 1, 'tipo5',5)
GO
INSERT INTO Vehiculo(numeroPasajeros,tieneArtilleria,tipo,idCamuflaje) VALUES(6, 1, 'tipo6',6)
GO
INSERT INTO Vehiculo(numeroPasajeros,tieneArtilleria,tipo,idCamuflaje) VALUES(7, 1, 'tipo6',7)
GO
INSERT INTO Vehiculo(numeroPasajeros,tieneArtilleria,tipo,idCamuflaje) VALUES(8, 1, 'tipo8',8)
GO
INSERT INTO Vehiculo(numeroPasajeros,tieneArtilleria,tipo,idCamuflaje) VALUES(9, 1, 'tipo9',9)
GO
INSERT INTO Vehiculo(numeroPasajeros,tieneArtilleria,tipo,idCamuflaje) VALUES(10, 1, 'tipo10',10)
GO
select *from Vehiculo
--INSERT VENTAJA
INSERT INTO ventaja(tiempodeRecarga,nombre,killsNecesarias,idArmerio) VALUES('tiempodeRecarga1', 'nombre1', 32,1)
GO
INSERT INTO ventaja(tiempodeRecarga,nombre,killsNecesarias,idArmerio) VALUES('tiempodeRecarga2', 'nombre2', 52,2)
GO
INSERT INTO ventaja(tiempodeRecarga,nombre,killsNecesarias,idArmerio) VALUES('tiempodeRecarga3', 'nombre3', 542,3)
GO
INSERT INTO ventaja(tiempodeRecarga,nombre,killsNecesarias,idArmerio) VALUES('tiempodeRecarga4', 'nombre4', 123,4)
GO
INSERT INTO ventaja(tiempodeRecarga,nombre,killsNecesarias,idArmerio) VALUES('tiempodeRecarga5', 'nombre5', 553,5)
GO
INSERT INTO ventaja(tiempodeRecarga,nombre,killsNecesarias,idArmerio) VALUES('tiempodeRecarga6', 'nombre6', 562,6)
GO
INSERT INTO ventaja(tiempodeRecarga,nombre,killsNecesarias,idArmerio) VALUES('tiempodeRecarga7', 'nombre7', 235,7)
GO
INSERT INTO ventaja(tiempodeRecarga,nombre,killsNecesarias,idArmerio) VALUES('tiempodeRecarga8', 'nombre8', 523,8)
GO
INSERT INTO ventaja(tiempodeRecarga,nombre,killsNecesarias,idArmerio) VALUES('tiempodeRecarga9', 'nombre9', 234,9)
GO
INSERT INTO ventaja(tiempodeRecarga,nombre,killsNecesarias,idArmerio) VALUES('tiempodeRecarga10', 'nombre10', 234,10)
GO
select *From ventaja
--INSERTS LOOT
INSERT INTO loot(tipo,cantidad,calidad,idMapa,idFupgrade) VALUES('tipo1', 'cantidad1', 'calidad1',1,1)
GO
INSERT INTO loot(tipo,cantidad,calidad,idMapa,idFupgrade) VALUES('tipo2', 'cantidad2', 'calidad2',2,2)
GO
INSERT INTO loot(tipo,cantidad,calidad,idMapa,idFupgrade) VALUES('tipo3', 'cantidad3', 'calidad3',3,3)
GO
INSERT INTO loot(tipo,cantidad,calidad,idMapa,idFupgrade) VALUES('tipo4', 'cantidad4', 'calidad4',4,4)
GO
INSERT INTO loot(tipo,cantidad,calidad,idMapa,idFupgrade) VALUES('tipo5', 'cantidad5', 'calidad5',5,5)
GO
INSERT INTO loot(tipo,cantidad,calidad,idMapa,idFupgrade) VALUES('tipo6', 'cantidad6', 'calidad6',6,6)
GO
INSERT INTO loot(tipo,cantidad,calidad,idMapa,idFupgrade) VALUES('tipo7', 'cantidad7', 'calidad6',7,7)
GO
INSERT INTO loot(tipo,cantidad,calidad,idMapa,idFupgrade) VALUES('tipo8', 'cantidad8', 'calidad8',8,8)
GO
INSERT INTO loot(tipo,cantidad,calidad,idMapa,idFupgrade) VALUES('tipo9', 'cantidad9', 'calidad9',9,9)
GO
INSERT INTO loot(tipo,cantidad,calidad,idMapa,idFupgrade) VALUES('tipo10', 'cantidad10', 'calidad10',10,10)
GO
select *from loot
--INSERTS AGENTEESCUADRON
INSERT INTO AgenteEscuadron(idAgente,idEscuadron) VALUES(1,1)
GO
INSERT INTO AgenteEscuadron(idAgente,idEscuadron) VALUES(2,2)
GO
INSERT INTO AgenteEscuadron(idAgente,idEscuadron) VALUES(3,3)
GO
INSERT INTO AgenteEscuadron(idAgente,idEscuadron) VALUES(4,4)
GO
INSERT INTO AgenteEscuadron(idAgente,idEscuadron) VALUES(5,5)
GO
INSERT INTO AgenteEscuadron(idAgente,idEscuadron) VALUES(6,6)
GO
INSERT INTO AgenteEscuadron(idAgente,idEscuadron) VALUES(7,7)
GO
INSERT INTO AgenteEscuadron(idAgente,idEscuadron) VALUES(8,8)
GO
INSERT INTO AgenteEscuadron(idAgente,idEscuadron) VALUES(9,9)
GO
INSERT INTO AgenteEscuadron(idAgente,idEscuadron) VALUES(10,10)
GO
--INSERT AGENTEGESTO
INSERT INTO AgenteGesto(idAgente,idGesto) VALUES(1,1)
GO
INSERT INTO AgenteGesto(idAgente,idGesto) VALUES(2,2)
GO
INSERT INTO AgenteGesto(idAgente,idGesto) VALUES(3,3)
GO
INSERT INTO AgenteGesto(idAgente,idGesto) VALUES(4,4)
GO
INSERT INTO AgenteGesto(idAgente,idGesto) VALUES(5,5)
GO
INSERT INTO AgenteGesto(idAgente,idGesto) VALUES(6,6)
GO
INSERT INTO AgenteGesto(idAgente,idGesto) VALUES(7,7)
GO
INSERT INTO AgenteGesto(idAgente,idGesto) VALUES(8,8)
GO
INSERT INTO AgenteGesto(idAgente,idGesto) VALUES(9,9)
GO
INSERT INTO AgenteGesto(idAgente,idGesto) VALUES(10,10)
GO
--INSERT BarraconVehiculo
INSERT INTO BarraconVehiculo(idBarracon,idVehiculo) VALUES(1,1)
GO
INSERT INTO BarraconVehiculo(idBarracon,idVehiculo) VALUES(2,2)
GO
INSERT INTO BarraconVehiculo(idBarracon,idVehiculo) VALUES(3,3)
GO
INSERT INTO BarraconVehiculo(idBarracon,idVehiculo) VALUES(4,4)
GO
INSERT INTO BarraconVehiculo(idBarracon,idVehiculo) VALUES(5,5)
GO
INSERT INTO BarraconVehiculo(idBarracon,idVehiculo) VALUES(6,6)
GO
INSERT INTO BarraconVehiculo(idBarracon,idVehiculo) VALUES(7,7)
GO
INSERT INTO BarraconVehiculo(idBarracon,idVehiculo) VALUES(8,8)
GO
INSERT INTO BarraconVehiculo(idBarracon,idVehiculo) VALUES(9,9)
GO
INSERT INTO BarraconVehiculo(idBarracon,idVehiculo) VALUES(10,10)
GO
select *from BarraconVehiculo
--INSERT CLIPPARTIDA
INSERT INTO ClipPartida(idClip,idPartida) VALUES(1,1)
GO
INSERT INTO ClipPartida(idClip,idPartida) VALUES(2,2)
GO
INSERT INTO ClipPartida(idClip,idPartida) VALUES(3,3)
GO
INSERT INTO ClipPartida(idClip,idPartida) VALUES(4,4)
GO
INSERT INTO ClipPartida(idClip,idPartida) VALUES(5,5)
GO
INSERT INTO ClipPartida(idClip,idPartida) VALUES(6,6)
GO
INSERT INTO ClipPartida(idClip,idPartida) VALUES(7,7)
GO
INSERT INTO ClipPartida(idClip,idPartida) VALUES(8,8)
GO
INSERT INTO ClipPartida(idClip,idPartida) VALUES(9,9)
GO
INSERT INTO ClipPartida(idClip,idPartida) VALUES(10,10)
GO
select *from ClipPartida
--INSERT CAPITULO TEMPORADA
INSERT INTO CapituloTemporada(idCapitulo,idTemporada) VALUES(1,1)
GO
INSERT INTO CapituloTemporada(idCapitulo,idTemporada) VALUES(2,2)
GO
INSERT INTO CapituloTemporada(idCapitulo,idTemporada) VALUES(3,3)
GO
INSERT INTO CapituloTemporada(idCapitulo,idTemporada) VALUES(4,4)
GO
INSERT INTO CapituloTemporada(idCapitulo,idTemporada) VALUES(5,5)
GO
INSERT INTO CapituloTemporada(idCapitulo,idTemporada) VALUES(6,6)
GO
INSERT INTO CapituloTemporada(idCapitulo,idTemporada) VALUES(7,7)
GO
INSERT INTO CapituloTemporada(idCapitulo,idTemporada) VALUES(8,8)
GO
INSERT INTO CapituloTemporada(idCapitulo,idTemporada) VALUES(9,9)
GO
INSERT INTO CapituloTemporada(idCapitulo,idTemporada) VALUES(10,10)
GO
select *from CapituloTemporada
--INSERT DESAFIO BATTLEPASS
INSERT INTO DesafioBattlepass(idDesafio,idBattlepass) VALUES(1,1)
GO
INSERT INTO DesafioBattlepass(idDesafio,idBattlepass) VALUES(2,2)
GO
INSERT INTO DesafioBattlepass(idDesafio,idBattlepass) VALUES(3,3)
GO
INSERT INTO DesafioBattlepass(idDesafio,idBattlepass) VALUES(4,4)
GO
INSERT INTO DesafioBattlepass(idDesafio,idBattlepass) VALUES(5,5)
GO
INSERT INTO DesafioBattlepass(idDesafio,idBattlepass) VALUES(6,6)
GO
INSERT INTO DesafioBattlepass(idDesafio,idBattlepass) VALUES(7,7)
GO
INSERT INTO DesafioBattlepass(idDesafio,idBattlepass) VALUES(8,8)
GO
INSERT INTO DesafioBattlepass(idDesafio,idBattlepass) VALUES(9,9)
GO
INSERT INTO DesafioBattlepass(idDesafio,idBattlepass) VALUES(10,10)
GO
select *from DesafioBattlepass
--INSERT ESCUADRON AGENTE
INSERT INTO EscuadronAgente(idEscuadron,idAgente) VALUES(1,1)
GO
INSERT INTO EscuadronAgente(idEscuadron,idAgente) VALUES(2,2)
GO
INSERT INTO EscuadronAgente(idEscuadron,idAgente) VALUES(3,3)
GO
INSERT INTO EscuadronAgente(idEscuadron,idAgente) VALUES(4,4)
GO
INSERT INTO EscuadronAgente(idEscuadron,idAgente) VALUES(5,5)
GO
INSERT INTO EscuadronAgente(idEscuadron,idAgente) VALUES(6,6)
GO
INSERT INTO EscuadronAgente(idEscuadron,idAgente) VALUES(7,7)
GO
INSERT INTO EscuadronAgente(idEscuadron,idAgente) VALUES(8,8)
GO
INSERT INTO EscuadronAgente(idEscuadron,idAgente) VALUES(9,9)
GO
INSERT INTO EscuadronAgente(idEscuadron,idAgente) VALUES(10,10)
GO
select *from EscuadronAgente
--INSERTS  JUGADOR PLATAFORMA
INSERT INTO JugadorPlataforma(idJugador,idPlataforma) VALUES(1,1)
GO
INSERT INTO JugadorPlataforma(idJugador,idPlataforma) VALUES(2,2)
GO
INSERT INTO JugadorPlataforma(idJugador,idPlataforma) VALUES(3,3)
GO
INSERT INTO JugadorPlataforma(idJugador,idPlataforma) VALUES(4,4)
GO
INSERT INTO JugadorPlataforma(idJugador,idPlataforma) VALUES(5,5)
GO
INSERT INTO JugadorPlataforma(idJugador,idPlataforma) VALUES(6,6)
GO
INSERT INTO JugadorPlataforma(idJugador,idPlataforma) VALUES(7,7)
GO
INSERT INTO JugadorPlataforma(idJugador,idPlataforma) VALUES(8,8)
GO
INSERT INTO JugadorPlataforma(idJugador,idPlataforma) VALUES(9,9)
GO
INSERT INTO JugadorPlataforma(idJugador,idPlataforma) VALUES(10,10)
GO
select *from JugadorPlataforma
--INSERT MAPA TEMPORADA
INSERT INTO MapaTemporada(idMapa,idTemporada) VALUES(1,1)
GO
INSERT INTO MapaTemporada(idMapa,idTemporada) VALUES(2,2)
GO
INSERT INTO MapaTemporada(idMapa,idTemporada) VALUES(3,3)
GO
INSERT INTO MapaTemporada(idMapa,idTemporada) VALUES(4,4)
GO
INSERT INTO MapaTemporada(idMapa,idTemporada) VALUES(5,5)
GO
INSERT INTO MapaTemporada(idMapa,idTemporada) VALUES(6,6)
GO
INSERT INTO MapaTemporada(idMapa,idTemporada) VALUES(7,7)
GO
INSERT INTO MapaTemporada(idMapa,idTemporada) VALUES(8,8)
GO
INSERT INTO MapaTemporada(idMapa,idTemporada) VALUES(9,9)
GO
INSERT INTO MapaTemporada(idMapa,idTemporada) VALUES(10,10)
GO

--delete from mapa
--DBCC CHECKIDENT ('dbo.Mapa', RESEED,0);
select *from comunidad