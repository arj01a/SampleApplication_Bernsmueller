CREATE TABLE [dbo].[Relation] (
    [RelationId]     INT      NOT NULL,
    [AccountId]      INT      NOT NULL,
    [PersonId]       INT      NOT NULL,
    [RelationTypeId] SMALLINT NOT NULL,
    PRIMARY KEY CLUSTERED ([RelationId] ASC),
    CONSTRAINT [FK_Relation_Account] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Account] ([AccountId]),
    CONSTRAINT [FK_Relation_Person] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId]),
    CONSTRAINT [FK_Relation_RelationType] FOREIGN KEY ([RelationTypeId]) REFERENCES [ddl].[RelationType] ([Id])
);

