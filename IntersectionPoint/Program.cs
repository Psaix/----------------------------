// Алгоритм нахождения точки пересечения прямой L, заданной двумя точками и перпендикулярной ей прямой, проходящей через точку A.
using System.Numerics;

// Задаем прямую L и точки А.
var firstPontL = Console.ReadLine().Split();
Vector2 startPointL = new Vector2(float.Parse(firstPontL[0]),float.Parse(firstPontL[1])); // координаты первой точки прямой L.

var secondPointL = Console.ReadLine().Split();
Vector2 endPointL = new Vector2(float.Parse(secondPointL[0]),float.Parse(secondPointL[1])); // координаты второй точки прямой L.

var knownPointOfP = Console.ReadLine().Split();
Vector2 pointA = new Vector2(float.Parse(knownPointOfP[0]),float.Parse(knownPointOfP[1])); // координаты точки A.

// Находим уравнение прямой P, проходящей через точку A и перпендикулярной прямой L
var kL = (endPointL.Y - startPointL.Y) / (endPointL.X - startPointL.X); // коэффициент наклона прямой L
var kP = -1 / kL; // коэффициент наклона прямой P
var bP = pointA.Y - kP * pointA.X; // коэффициент b у уравнения прямой P: y = kP*x + bP.

// Находим координаты точки пересечения прямой L и прямой P
var xIntersection = (bP - startPointL.Y + kL * startPointL.X) / (kL - kP); 
var yIntersection = kP * xIntersection + bP;

//Выводим ответ в терминал.
Console.WriteLine($"Точка пересечения прямой L и прямой P: {xIntersection}; {yIntersection}");
