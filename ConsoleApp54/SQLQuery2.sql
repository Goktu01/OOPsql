select * from Categories

select * from Customers where City='London'

select * from Products where CategoryID=1 or CategoryID=4

select * from Products order by UnitPrice asc

select COUNT(*) from Customers

select CategoryID, COUNT(*) from Products group by CategoryID having COUNT(*)>10

select Products.ProductID, Products.ProductName, products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10


select * from Customers c left join Orders o on c.CustomerID = o.CustomerID 
where o.CustomerID is null