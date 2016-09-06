-- This Creates the WINES Database

 /*    State Table  */                                                   
CREATE TABLE  STATE                                                     
      (SID           CHAR(03) NOT NULL,                                 
       SNAME         CHAR(40) NOT NULL,                    
       PRIMARY KEY  (SID));               
                                                                                
 /*     Producer Table  */                                                       
CREATE TABLE  PRODUCER                                                  
      (PID           CHAR(06) NOT NULL,                                 
       PNAME         CHAR(40) NOT NULL,                    
       PRIMARY KEY  (PID));                                              
                                                                              
 /*     Wine Class Table  */                                                     
CREATE TABLE  CLASS                                                     
      (CID           CHAR(06) NOT NULL,                                 
       CNAME         CHAR(40) NOT NULL,                    
       COLOUR        CHAR(05),                                          
       PRIMARY KEY  (CID));                                              
                                                                               
 /*     Region Table   */                                                        
CREATE TABLE  REGION                                                    
      (RID           CHAR(08) NOT NULL,                                 
       SID           CHAR(03) NOT NULL,                                 
       RNAME         CHAR(40) NOT NULL,                    
       PRIMARY KEY  (RID),                                              
       FOREIGN KEY  (SID)                                            
       REFERENCES    STATE);                                                     

 /*     Vineyard Table   */                                                      
CREATE TABLE  VINEYARD                                                  
      (VID           CHAR(08) NOT NULL,                                 
       PID           CHAR(06) NOT NULL,                                 
       RID           CHAR(08) NOT NULL,                                 
       VNAME         CHAR(40) NOT NULL,                    
       VMANAGER      CHAR(40) NOT NULL, 
       COMMENTS      CHAR(200),                   
       PRIMARY KEY  (VID),                                              
       FOREIGN KEY  (PID)                                          
       REFERENCES    PRODUCER,                                                  
       FOREIGN KEY  (RID)                                              
       REFERENCES    REGION);                                           
                                                                                
 /*     Wine Table    */                                                         
CREATE TABLE  WINE                                                      
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
       REFERENCES    VINEYARD,                                                  
       FOREIGN KEY  (CID)                                               
       REFERENCES    CLASS);