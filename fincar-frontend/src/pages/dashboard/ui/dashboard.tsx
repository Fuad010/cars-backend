import { Sidebar } from 'widgets/sidebar'
import styles from './dashboard.module.css'

export const Dashboard = () => {
    return(
        <div className={styles.wrapper}>
            <Sidebar />
        </div>
    )
}