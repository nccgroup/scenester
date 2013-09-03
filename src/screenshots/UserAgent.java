/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package screenshots;

/**
 *
 * @author Sharique
 */
public class UserAgent {
    private String description=null;
    private String userAgent=null;

    public UserAgent() {
        description="";
        userAgent="";
    }
    public UserAgent(String description, String userAgent) {
        this.description = description;
        this.userAgent=userAgent;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getUserAgent() {
        return userAgent;
    }

    public void setUserAgent(String userAgent) {
        this.userAgent = userAgent;
    }
    @Override
    public String toString()
    {
       return description; 
    }
    
}
