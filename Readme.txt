First Time migration. Every time migrate two context
----------------------------------------------
PM>Add-Migration init -Context ApplicationDbContext
PM>Update-Database -Context ApplicationDbContext

PM>Add-Migration init -Context ApiDbContext
PM>Update-Database -Context ApiDbContext

-------------------------End-------------------

Update Model
----------------------------------------------- 
PM>Add-Migration -Context ApplicationDbContext
PM>Update-Database -Context ApplicationDbContext

or

PM>Add-Migration -Context ApiDbContext
PM>Update-Database -Context ApiDbContext

------------------------End---------------------