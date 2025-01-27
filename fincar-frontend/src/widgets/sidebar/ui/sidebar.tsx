import { Link, useLocation } from 'react-router-dom'
import styles from './sidebar.module.css'
import { useEffect, useState } from 'react'
 

export const Sidebar = () => {
    const [isActiveButton, setIsActiveButton] = useState<boolean>(false);

    const location = useLocation();
    console.log(location);
    
    useEffect(() => {
        if (location.pathname.includes(`/dashboard/see-all-cars`)) {
            setIsActiveButton(true);
        } else {
            setIsActiveButton(false);
        }
    }, [location.pathname]); 

    return(
        <div className={styles.wrapper}>
            
            <Link 
                to="/dashboard/see-all-cars" 
                className={isActiveButton ? styles.active : ''} 
            >
                See All Cars
            </Link>
            <Link 
                to="/dashboard/create-new-car" 
                className={!isActiveButton ? styles.active : ''} 
            >
                Create New Car
            </Link>
        </div>
    )
}