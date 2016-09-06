column table_name format A8
column index_name format A12
column column_name format A12
column data_type format A12

select table_name, num_rows, blocks, empty_blocks, avg_space, avg_row_len
from user_tables
where table_name in ('STATE','REGION','PRODUCER','CLASS','VINEYARD','WINE')
order by 1;

select table_name, column_name, data_type, data_length, nullable, num_distinct
from user_tab_columns
where table_name in ('STATE','REGION','PRODUCER','CLASS','VINEYARD','WINE')
order by table_name, column_id;

select table_name, index_name, column_position, column_name
from user_ind_columns
where table_name in ('STATE','REGION','PRODUCER','CLASS','VINEYARD','WINE')
order by 1,2,3;

select table_name, index_name, uniqueness, blevel, leaf_blocks,
       distinct_keys, clustering_factor
from user_indexes
where table_name in ('STATE','REGION','PRODUCER','CLASS','VINEYARD','WINE')
order by 1,2;