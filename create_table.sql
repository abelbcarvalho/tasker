-- postgres format : import and run
-- the database name should obey what is writen on .env file

create table if not exists Taskers
(
    id serial not null primary key,
    title varchar(128) not null,
    description varchar(255),
    priority varchar(32) not null,
    complete boolean not null,
    startAt timestamp not null,
    finishAt timestamp not null
);