create database convoy;
create table public.convoy
(
    shipment_id   serial,
    shipper_id    integer,
    date_time     timestamp,
    pickup_state  char(2),
    dropoff_state char(2)
);
comment on table public.convoy is 'CONVOY Table ';
alter table public.convoy
    alter column shipper_id type varchar(100) using shipper_id::varchar(100);
alter table public.convoy
    alter column shipper_id set not null;
INSERT INTO public.convoy (shipper_id, date_time, pickup_state, dropoff_state)
VALUES ('shipper_1', '2024-06-10 10:00:00', 'CA', 'NY'),
       ('shipper_2', '2024-06-11 15:30:00', 'TX', 'FL'),
       ('shipper_3', '2024-06-12 08:45:00', 'IL', 'WA'),
       ('shipper_4', '2024-06-13 14:00:00', 'OH', 'PA'),
       ('shipper_5', '2024-06-14 09:30:00', 'GA', 'NC'),
       ('shipper_6', '2024-06-15 11:15:00', 'MA', 'VT'),
       ('shipper_7', '2024-06-16 16:45:00', 'NJ', 'DE'),
       ('shipper_8', '2024-06-17 12:00:00', 'VA', 'WV'),
       ('shipper_9', '2024-06-18 08:00:00', 'SC', 'NC'),
       ('shipper_10', '2024-06-19 13:45:00', 'TN', 'KY'),
       ('shipper_11', '2024-06-20 09:30:00', 'MI', 'OH'),
       ('shipper_12', '2024-06-21 11:15:00', 'IN', 'IL'),
       ('shipper_13', '2024-06-22 16:45:00', 'WI', 'MN'),
       ('shipper_14', '2024-06-24 12:00:00', 'MO', 'KS'),
       ('shipper_15', '2024-06-25 08:00:00', 'AR', 'LA'),
       ('shipper_16', '2024-06-26 13:45:00', 'OK', 'TX'),
       ('shipper_17', '2024-06-27 09:30:00', 'CO', 'NM'),
       ('shipper_18', '2024-06-28 11:15:00', 'AZ', 'UT'),
       ('shipper_19', '2024-06-29 16:45:00', 'NV', 'CA'),
       ('shipper_20', '2024-07-01 12:00:00', 'WA', 'OR'),
       ('shipper_21', '2024-07-02 08:00:00', 'ID', 'MT'),
       ('shipper_22', '2024-07-03 13:45:00', 'WY', 'SD'),
       ('shipper_23', '2024-07-04 09:30:00', 'ND', 'MN'),
       ('shipper_24', '2024-07-05 11:15:00', 'IA', 'MO'),
       ('shipper_25', '2024-07-06 16:45:00', 'IL', 'WI'),
       ('shipper_26', '2024-07-08 12:00:00', 'KY', 'TN'),
       ('shipper_27', '2024-07-09 08:00:00', 'WV', 'VA');



/*
Write a query that returns the total shipments for each shipper. 
If the shipper has performed some shipments that were picked up or dropped off in 'CA',
add '_CA' to the end of `shipper_id`,
Requirement : 
- Expected columns : `shipper_id`, `total`n in that order
- Sort the rows by `total`descending, then by `shipper_id`ascending
*/
SELECT
  CASE
    WHEN SUM(CASE WHEN pickup_state = 'CA' OR dropoff_state = 'CA' THEN 1 ELSE 0 END) > 0
    THEN CONCAT(shipper_id, '_CA')
    ELSE shipper_id
  END AS shipper_id,
  COUNT(*) AS total
FROM convoy
GROUP BY shipper_id
ORDER BY total DESC, shipper_id ASC;


/*
Write a query that returns the total number of shipments (regardless of the pickup state) by shippers,
but only for the shippers that have made strictly more than 6 shipments picked up in 'WA'.
Requirements :
- Expected columns are `shipper_id`, `total`, in that order
- Sort the rows by `total` descending, then by `shipper_id` ascending
*/
SELECT c.shipper_id, COUNT(c.shipper_id) AS total
FROM convoy c
WHERE c.shipper_id IN (
    SELECT c1.shipper_id AS id
    FROM convoy c1
    WHERE c1.pickup_state = 'WA'
    GROUP BY c1.shipper_id
    HAVING COUNT(*) > 0
)
GROUP BY c.shipper_id
ORDER BY total DESC, c.shipper_id ASC;
;




