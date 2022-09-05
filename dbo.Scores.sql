CREATE TABLE [dbo].[Scores] (
    [id]                   INT           IDENTITY (1, 1) NOT NULL,
    [player_name]          NVARCHAR (20) NOT NULL,
    [game_duration]        INT           NOT NULL,
    [number_of_guesses]    SMALLINT      NOT NULL,
    [has_guessed_solution] BIT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

