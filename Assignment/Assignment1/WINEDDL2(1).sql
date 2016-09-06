-- This Creates the WINES2 Database tables

 /*    State2 Table  */                                                   
CREATE TABLE  STATE2                                                     
      (SID           CHAR(03) NOT NULL,                                 
       SNAME         CHAR(40) NOT NULL,                    
       PRIMARY KEY  (SID)) TABLESPACE USERS2K;               
                                                                                
 /*     Producer Table  */                                                       
CREATE TABLE  PRODUCER2                                                  
      (PID           CHAR(06) NOT NULL,                                 
       PNAME         CHAR(40) NOT NULL,                    
       PRIMARY KEY  (PID)) TABLESPACE USERS2K;                                              
                                                                              
 /*     Wine Class Table  */                                                     
CREATE TABLE  CLASS2                                                     
      (CID           CHAR(06) NOT NULL,                                 
       CNAME         CHAR(40) NOT NULL,                    
       COLOUR        CHAR(05),                                          
       PRIMARY KEY  (CID)) TABLESPACE USERS2K;                                              
                                                                               
 /*     Region Table   */                                                        
CREATE TABLE  REGION2                                                    
      (RID           CHAR(08) NOT NULL,                                 
       SID           CHAR(03) NOT NULL,                                 
       RNAME         CHAR(40) NOT NULL,                    
       PRIMARY KEY  (RID),                                              
       FOREIGN KEY  (SID)                                            
       REFERENCES    STATE2) TABLESPACE USERS2K;                                                     

 /*     Vineyard Table   */                                                      
CREATE TABLE  VINEYARD2                                                  
      (VID           CHAR(08) NOT NULL,                                 
       PID           CHAR(06) NOT NULL,                                 
       RID           CHAR(08) NOT NULL,                                 
       VNAME         CHAR(40) NOT NULL,                    
       VMANAGER      CHAR(40) NOT NULL, 
       COMMENTS      CHAR(200),                   
       PRIMARY KEY  (VID),                                              
       FOREIGN KEY  (PID)                                          
       REFERENCES    PRODUCER2,                                                  
       FOREIGN KEY  (RID)                                              
       REFERENCES    REGION2) TABLESPACE USERS2K;                                           
                                                                                
 /*     Wine Table    */                                                         
CREATE TABLE  WINE2                                                      
      (VINTAGE       NUMBER(4)   NOT NULL,                                
       WINE_NO       SMALLINT    NOT NULL,                                        
       VID           CHAR(08)    NOT NULL,                                
       CID           CHAR(06)    NOT NULL,                                
       PCTALC        NUMBER(4,2),                                          
       PRICE         NUMBER(6,2),                                          
       GRADE         CHAR(01)    NOT NULL,                                
       WNAME         CHAR(40)    NOT NULL,                   
       COMMENTS      CHAR(200)   NOT NULL,                   
       PRIMARY KEY  (VINTAGE,                                           
                     WINE_NO),                                                
       FOREIGN KEY  (VID)                                               
       REFERENCES    VINEYARD2,                                                  
       FOREIGN KEY  (CID)                                               
       REFERENCES    CLASS2) TABLESPACE USERS2K
       cluster wine(vid, cid);