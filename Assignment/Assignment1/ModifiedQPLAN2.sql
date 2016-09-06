Rem These SQL statements allow you to view plans

Rem 1) Display Stats

column table_name format A8
column index_name format A13
column column_name format A12
column data_type format A12

select table_name, num_rows, blocks,empty_blocks, avg_space, avg_row_len
from user_tables
where table_name in ('STATE2','REGION2','PRODUCER2','CLASS2','VINEYARD2','WINE2')
order by 1;

select table_name, column_name, data_type, data_length, nullable, num_distinct
from user_tab_columns
where table_name in ('STATE2','REGION2','PRODUCER2','CLASS2','VINEYARD2','WINE2')
order by table_name, column_id;

select table_name, index_name, column_position, column_name
from user_ind_columns
where table_name in ('STATE2','REGION2','PRODUCER2','CLASS2','VINEYARD2','WINE2')
order by 1,2,3;

select table_name, index_name, uniqueness, blevel, leaf_blocks,
       distinct_keys, clustering_factor
from user_indexes
where table_name in ('STATE2','REGION2','PRODUCER2','CLASS2','VINEYARD2','WINE2')
order by 1,2;

Rem 2) Execute your SQL statement to make sure it is correct.

select vintage, wine_no, wname, pctalc, grade, price, wine.vid,
vname, wine.cid, cname
from vineyard, class, wine
where wine.vid = vineyard.vid
and wine.cid = class.cid
and wine.cid = 'SHIRAZ' and grade = 'A' ;

select  vintage, wine_no, wname, pctalc, grade, price, wine2.vid, vname, wine2.cid, cname 
from    vineyard2, class2, wine2 
where   wine2.vid = vineyard2.vid
and     wine2.cid = class2.cid
and     wine2.vid = 'V318' and wine2.grade = 'A';



Rem 3) Remove any old plan information from plan table

delete from plan_table;

Rem 4) Instruct Oracle to explain the plan for your sql statement.
 
 
explain plan for
select /*+index(wine wvgcidx)*/vintage, wine_no, wname, pctalc, grade, price, wine.vid,
vname, wine.cid, cname
from vineyard, class, wine
where wine.vid = vineyard.vid
and wine.cid = class.cid
and wine.cid = 'SHIRAZ' and grade = 'A' ;

explain plan for
select /*+index(wine2 wvcgidx2)*/vintage, wine_no, wname, pctalc, grade, price, wine2.vid,
vname, wine2.cid, cname
from vineyard2, class2, wine2
where wine2.vid = vineyard2.vid
and wine2.cid = class2.cid
and wine2.cid = 'SHIRAZ' and grade = 'A' ;




Rem 5) Query the DD to view the indexes 

column table_name format A8
column index_name format A13

select table_name, index_name, uniqueness, blevel, leaf_blocks,
       distinct_keys, clustering_factor
from user_indexes
where table_name in ('STATE','REGION','PRODUCER','CLASS','VINEYARD','WINE')
order by 1,2;


Rem 6) Query the plan table to view the plan 

select to_char(id,'99')||lpad(' ',2*level,'_')||operation||' '
      ||options||' '
      ||object_name
      ||' Cost = '||cost
      query_plan
      from plan_table
      connect by prior id = parent_id
      start with id = 0;