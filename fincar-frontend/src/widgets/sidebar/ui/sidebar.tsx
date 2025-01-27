import { Link, useLocation } from 'react-router-dom'
import styles from './sidebar.module.css'
import { useEffect, useState } from 'react'
 

export const Sidebar = () => {
    const [isActiveButton, setIsActiveButton] = useState<boolean>(false);

    const location = useLocation();

    useEffect(() => {
        if (location.pathname.includes(`dashboard/`)) {
            setIsActiveButton(false);
        } else {
            setIsActiveButton(true);
        }
    }, [location.pathname]); 

    return(
        <div className={styles.wrapper}>
            
            <Link 
                to="/dashboard" 
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