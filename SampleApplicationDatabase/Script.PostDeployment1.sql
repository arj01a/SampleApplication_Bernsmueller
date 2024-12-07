/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO [dbo].[Account](AccountId, Number, Name)
VALUES(1, 100, 'Account 1'),
      (2, 200, 'Account 2')


INSERT INTO [dbo].[Person](PersonId, FirstName, LastName)
VALUES(1, 'First Name 1', 'Last Name 1'),
      (2, 'First Name 2', 'Last Name 2')

INSERT INTO [ddl].[RelationType](Id, Name)
VALUES(1, 'Owner'),
      (2, 'Beneficiary')

INSERT INTO [dbo].[Relation](RelationId, AccountId, PersonId, RelationTypeId)
VALUES(1, 1, 1, 1),
      (2, 1, 2, 2),
      (3, 2, 1, 1)


