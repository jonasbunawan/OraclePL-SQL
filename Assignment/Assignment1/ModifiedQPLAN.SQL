Rem These SQL statements allow you to view plans


Rem 1a) Instruct Oracle to explain the plan for your sql statement.
 
explain plan for
select vintage, wine_no, wname, pctalc, grade, price, wine.vid,
vname, wine.cid, cname
from vineyard, class, wine
where wine.vid = vineyard.vid
and wine.cid = class.cid
and wine.cid = 'SHIRAZ' and grade = 'A' ;

explain plan for
select vintage, wine_no, wname, pctalc, grade, price, wine2.vid,
vname, wine2.cid, cname
from vineyard2, class2, wine2
where wine2.vid = vineyard2.vid
and wine2.cid = class2.cid
and wine2.cid = 'SHIRAZ' and grade = 'A' ;

explain plan for
select /*+first_rows(1)*/vintage, wine_no, wname, pctalc, grade, price, wine2.vid,
vname, wine2.cid, cname
from vineyard2, class2, wine2
where wine2.vid = vineyard2.vid
and wine2.cid = class2.cid
and wine2.cid = 'SHIRAZ' and grade = 'A' ;

Rem 1b) Instruct Oracle to explain the plan for the first rows of your sql statement.

explain plan for
select /*+first_rows(1)*/vintage, wine_no, wname, pctalc, grade, price, wine.vid,
vname, wine.cid, cname
from vineyard, class, wine
where wine.vid = vineyard.vid
and wine.cid = class.cid
and wine.cid = 'SHIRAZ' and grade = 'A' ;

Rem 2) Query the DD to view the indexes 

column table_name format A8
column index_name format A13

select table_name, index_name, uniqueness, blevel, leaf_blocks,
       distinct_keys, clustering_factor
from user_indexes
where table_name in ('STATE2','REGION2','PRODUCER2','CLASS2','VINEYARD2','WINE2')
order by 1,2;


Rem 3) Query the plan table to view the plan 

SELECT * 
FROM   TABLE(DBMS_XPLAN.DISPLAY);

create index wcidx2 on wine2(cid);
drop index wcidx;
create index wgidx2 on wine2(grade);
drop index wgidx;
create index wvidx2 on wine2(vid);
drop index wvidx;
create index wcgidx2 on wine2(cid, grade);
drop index wcgidx;
create index wgcidx2 on wine2(grade, cid);
drop index wgcidx;
create index wcvidx2 on wine2(cid, vid);
drop index wcvidx;
create index wvcidx2 on wine2(vid, cid);
drop index wvcidx;
create index wgvidx2 on wine2(grade, vid);
drop index wgvidx;
create index wvgidx2 on wine2(vid, grade);
drop index wvgidx;
create index wcgvidx2 on wine2(cid, grade, vid);
drop index wcgvidx;
create index wcvgidx2 on wine2(cid, vid, grade);
drop index wcvgidx;
create index wgvcidx2 on wine2(grade, vid, cid);
drop index wgvcidx2;
create index wgcvidx2 on wine2(grade, cid, vid);
drop index wgcvidx2;

create index wvcgidx2 on wine2(vid, cid, grade);
drop index wvcgidx;
create index wvgcidx2 on wine2(vid, grade, cid);
drop index wvgcidx;
