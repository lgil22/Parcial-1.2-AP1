Create database RegEvaluacionDb
GO

use RegEvaluacionDb

go
create table Evaluaciones
(
  Id int primary key identity,
  Estudiante varchar (30),
  Valor decimal(6,2),
  Logrado decimal(6,2),
  Perdido decimal(6,2),
  Fecha Datetime,

);