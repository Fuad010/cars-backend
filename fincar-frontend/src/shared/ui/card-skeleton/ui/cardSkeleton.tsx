import { Skeleton } from "antd"
import styles from './cardSkeleton.module.css'

export const CardSkeleton = () => {
    return (
    <div className={styles.wrapper}>
        <div className={styles.skeletonImage}>
                <Skeleton.Node active={true} style={{width:'100%', height:"100%" }} />
        </div>
        <div className={styles.bottomSkeleton}>
            <Skeleton.Input active={true} size="small" style={{width:'100%', height:'100%'}} />
            <Skeleton.Input active={true} size="small" style={{width:'100%', height:'100%'}} />
        </div>
    </div>
)
}   