import { Sidebar } from 'widgets/sidebar'
import styles from './dashboardLayout.module.css'
import { Outlet } from 'react-router-dom'

export const DashboardLayout = () => {
    return(
        <div className={styles.wrapper}>
            <Sidebar />
            <Outlet />
        </div>
    )
}