analyze table state compute statistics;
analyze table region compute statistics;
analyze table producer compute statistics;
analyze table class compute statistics;
analyze table vineyard compute statistics;
analyze table wine compute statistics;


explain plan for
select vintage, wine_no, wname, pctalc, grade, price, wine.vid, vname, wine.cid, cname 
from vineyard, class, wine 
where wine.vid = vineyard.vid 
and wine.cid = class.cid 
and wine.cid = 'SHIRAZ' and grade = 'A' AND pctalc = 12.6;

CREATE CLUSTER WINEv(VID CHAR(08));
create index winevidx on cluster winev;
create cluster winec(cid char(06));
create index winecidx on cluster winec;
drop cluster wine;

explain plan for
select vintage, wine_no, wname, pctalc , grade
from wine
where wine.cid = 'SHIRAZ' and grade = 'A' ;
