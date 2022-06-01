using System;
using MySql.Data.MySqlClient;
using Flexlive.CQP.Framework;
using System.Data.SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace kiki.zjcj.smallgreen
{
    public class Class1 : CQAppAbstract
    {
        #region 变量定义
        SQLiteConnection QL = new SQLiteConnection("Data Source=kiki.db;Pooling=true;FailIfMissing=false;");
        SQLiteConnection YX = new SQLiteConnection("Data Source=kiki.db;Pooling=true;FailIfMissing=false;");
        SQLiteConnection QT = new SQLiteConnection("Data Source=kiki.db;Pooling=true;FailIfMissing=false;");
        MySqlConnection YCSJK = new MySqlConnection("server=9m8h3be1.2266.dnstoo.com;user id=sghaqi_f;password=asasas;database=sghaqi;");
        SQLiteConnection ck = new SQLiteConnection("Data Source=app/moe.min.qa/qav2.db;Pooling=true;FailIfMissing=false;");
        System.Timers.Timer shizhong = new System.Timers.Timer(1000);
        public override void Initialize()
        {
            this.Name = "kiki1";
            this.Version = new Version("1.1.1.1");
            this.Author = "taki";
            this.Description = "基基";
        }
        int xtkg = 0;
        public override void Startup()
        {
            //if (xtkg == 0)
            //{
            //    xtkg = 1;
            //    QL.Open();
            //    QL.Open();
            //    QT.Open();
            //    ck.Open();
            //    kqsj = DateTime.Now;
            //    YCZT();
            //    shizhong.Elapsed += new System.Timers.ElapsedEventHandler(Timer_TimesUp);
            //    shizhong.AutoReset = true;
            //    shizhong.Enabled = true;
            //    shizhong.Start();
            //}
        }
        long admin1 = 1198089094;
        long admin2 = 812895112;
        long dlqq;
        int jjyc;
        long mz;
        long fz;
        long sz = 999;
        long day;
        string jtjh;
        int jtjhkg;
        long xlkjqqq = 490392598;
        string xq;
        DateTime kqsj;
        int month;
        int zsh;
        int zwh;
        int wsh;
        int dsxxkg;
        int intimer = 0;
        int yxjc;
        DateTime dsjgsj;
        DateTime dqsj;
        int tpdskg;
        #endregion
        private void Timer_TimesUp(object sender, System.Timers.ElapsedEventArgs e)
        {
            mz++;
            if (Interlocked.Exchange(ref intimer, 1) == 0)
            {
                if (fqdz > 0)
                {
                    fqdz--;
                }
                if (mz == 60)
                {
                    mz = 0;
                    fz++;
                    if (dsxxkg == 1)
                    {
                        Dsxx();
                    }
                    if (tpdskg == 1)
                    {
                        dqsj = DateTime.Parse(DateTime.Now.ToShortTimeString());
                        SQLiteCommand tpds = new SQLiteCommand("select count(*) from 绿绿联盟列表 where zt='1' and time='" + dqsj + "'", QL);
                        int n = int.Parse(tpds.ExecuteScalar().ToString());
                        if (n > 0)
                        {
                            SQLiteCommand tpds2 = new SQLiteCommand("select * from 绿绿联盟列表 where zt='1' and time='" + dqsj + "'", QL);
                            SQLiteDataReader tpds3 = tpds2.ExecuteReader();
                            while (tpds3.Read())
                            {
                                SQLiteCommand tpds4 = new SQLiteCommand("UPDATE 绿绿联盟列表 set time='0',zt='0',ps='0',time='0' where qh='" + tpds3[1].ToString() + "'", QL);
                                tpds4.ExecuteNonQuery();
                                CQ.SendGroupMessage(Convert.ToInt64(tpds3[1].ToString()), String.Format("【投票惩罚】\n时间到 投票结束qwq"));
                            }
                        }
                    }
                    if (fz == 60)
                    {
                        mz = long.Parse(DateTime.Now.Second.ToString());
                        fz = long.Parse(DateTime.Now.Minute.ToString());
                        sz = int.Parse(DateTime.Now.Hour.ToString());
                        TCQ.Clear();
                        if (sz == 0 && jtjhkg == 0)
                        {
                            jtjhkg = 1;
                            CQ.SendGroupMessage(xlkjqqq, String.Format("签到"));
                            jtjh = DateTime.Now.ToLongDateString().ToString();
                            xq = DateTime.Now.DayOfWeek.ToString();
                            day = long.Parse(DateTime.Now.Day.ToString());
                            month = int.Parse(DateTime.Now.Month.ToString());
                        }
                        else if (sz >= 1 && sz < 6)
                        {
                            jkxtkg = 1;
                        }
                        else if (sz == 6 && zsh == 0)
                        {
                            zsh = 1;
                            jkxtkg = 0;
                            XJQCY.Clear();
                            Dlb("早上好QWQ 新的一天要继续加油哦~");
                        }
                        else if (sz == 12 && zwh == 0)
                        {
                            zwh = 1;
                            Dlb("中午好QAQ饿死本宝宝惹");
                        }
                        else if (sz == 22 && wsh == 0)
                        {
                            wsh = 1;
                            Dlb("基基去碎觉啦qwq么么哒");
                        }
                        #region 判断系统是否已启动
                        if (yxjc == 0)
                        {
                            System.Diagnostics.Process[] myProcesses1 = System.Diagnostics.Process.GetProcessesByName("运行监测");//获取指定的进程名   
                            if (myProcesses1.Length > 0) //如果可以获取到知道的进程名则说明已经启动
                            {
                                yxjc = 1;
                            }
                            else
                            {
                                if (File.Exists("运行监测.exe"))
                                {
                                    System.Diagnostics.Process.Start("运行监测.exe");
                                    CQ.SendPrivateMessage(admin1, String.Format("运行监测已启动"));
                                    yxjc = 1;
                                }
                                else
                                {
                                    CQ.SendPrivateMessage(admin1, String.Format("基基未发现目录下存在运行监测 无法启动"));
                                }
                            }
                        }
                        #endregion
                    }
                    if (sz == 23 && fz > 55)
                    {
                        mz = long.Parse(DateTime.Now.Second.ToString());
                        fz = long.Parse(DateTime.Now.Minute.ToString());
                        sz = int.Parse(DateTime.Now.Hour.ToString());
                        jkxtkg = 0;
                        jtjhkg = 0;
                        zsh = 0;
                        zwh = 0;
                        wsh = 0;
                    }
                }
                if (zdmr == 1 && mz % 2 == 0)
                {
                    Mrmskq(mrqh);
                }
                Interlocked.Exchange(ref intimer, 0);
            }
        }
        
        #region    群管
        //定时消息
        public void Dsxx()
        {
            dqsj = DateTime.Parse(DateTime.Now.ToShortTimeString());
            SQLiteCommand dscx = new SQLiteCommand("select count(*) from 定时消息 where ZT='1' and CSH='" + dqsj + "'", QL);
            int m = int.Parse(dscx.ExecuteScalar().ToString());
            if (m > 0)
            {
                SQLiteCommand dscx2 = new SQLiteCommand("select * from 定时消息 where ZT='1' and CSH='" + dqsj + "'", QL);
                SQLiteDataReader dscxr = dscx2.ExecuteReader();
                while (dscxr.Read())
                {
                    if (dscxr[4].ToString() == "2")
                    {
                        SQLiteCommand dscx3 = new SQLiteCommand("UPDATE 定时消息 set ZT='0' where id='" + dscxr[0].ToString() + "'", QL);
                        dscx3.ExecuteNonQuery();
                    }
                    else
                    {
                        var b = dqsj.AddMinutes(long.Parse(dscxr[3].ToString()));
                        SQLiteCommand dscx3 = new SQLiteCommand("UPDATE 定时消息 set CSH='" + b + "' where id='" + dscxr[0].ToString() + "'", QL);
                        dscx3.ExecuteNonQuery();
                    }
                    CQ.SendGroupMessage(Convert.ToInt64(dscxr[2].ToString()), String.Format("{0}", dscxr[1].ToString()));
                }
                SQLiteCommand hym = new SQLiteCommand("select count(*) from 定时消息 where ZT='1'", QL);
                if (int.Parse(hym.ExecuteScalar().ToString()) == 0)
                {
                    dsxxkg = 0;
                }
            }
        }
        //异常状态
        List<long> LLLM = new List<long>();
        List<long> XJQCY = new List<long>();
        List<long> TCQ = new List<long>();
        public void YCZT()
        {
            CQ.SendPrivateMessage(admin1, String.Format("基基正在启动......"));
            dlqq = CQ.GetLoginQQ();
            if (yxjc == 0)
            {
                System.Diagnostics.Process[] myProcesses1 = System.Diagnostics.Process.GetProcessesByName("运行监测");//获取指定的进程名   
                if (myProcesses1.Length > 0) //如果可以获取到知道的进程名则说明已经启动
                {
                    yxjc = 1;
                    CQ.SendPrivateMessage(admin1, String.Format("运行监测已经启动"));
                }
                else
                {
                    if (File.Exists("运行监测.exe"))
                    {
                        System.Diagnostics.Process.Start("运行监测.exe");
                        CQ.SendPrivateMessage(admin1, String.Format("运行监测启动完成"));
                        yxjc = 1;
                    }
                    else
                    {
                        CQ.SendPrivateMessage(admin1, String.Format("基基未发现目录下存在运行监测 无法启动"));
                    }
                }
            }
            KKGG();
            try
            {
                SQLiteCommand lllmqh = new SQLiteCommand("select count(*) from 绿绿联盟列表", QL);
                lllmqhds =long.Parse(lllmqh.ExecuteScalar().ToString());
                if (lllmqhds > 0)
                {
                    LLLM.Clear();
                    SQLiteCommand lllm1 = new SQLiteCommand("select qh from 绿绿联盟列表", QL);
                    SQLiteDataReader lllm2 = lllm1.ExecuteReader();
                    while (lllm2.Read())
                    {
                        LLLM.Add(Convert.ToInt64(lllm2[0].ToString()));
                    }
                }
                slkg = 0;
                qlkg = 0;
                CQ.SendPrivateMessage(admin1, String.Format("基基与主数据库连接正常 发现{0}个绿绿联盟群",lllmqhds));
            }
            catch
            {
                slkg = 1;
                qlkg = 1;
                CQ.SendPrivateMessage(admin1, String.Format("基基与主数据库连接出错 已暂停服务"));
            }
            try
            {
                YCSJK.Open();
                MySqlCommand cop = new MySqlCommand("select id from kiki_user where QQ='"+admin1+"'",YCSJK);
                cop.ExecuteNonQuery();
                YCSJK.Close();
                YCSJK.Dispose();
                xyh = 0;
                CQ.SendPrivateMessage(admin1, String.Format("基基与远程数据库连接正常"));
            }
            catch
            {
                xyh = 1;
                YCSJK.Close();
                YCSJK.Dispose();
                CQ.SendPrivateMessage(admin1, String.Format("基基与远程数据库连接出错 已暂停注册新用户"));
            }
            string zt = CQ.ProxyType.ToString();
            if (zt.Contains("Nat"))
            {
                jjyc = 2;
                CQ.SendPrivateMessage(admin1, String.Format("检测到基基运行环境异常 可能导致部分功能无法使用"));
            }
            try
            {
                dqsj = DateTime.Parse(DateTime.Now.ToShortTimeString());
                SQLiteCommand dscx = new SQLiteCommand("select count(*) from 定时消息 where ZT='1'", QL);
                int i = int.Parse(dscx.ExecuteScalar().ToString());
                if (i > 0)
                {
                    SQLiteCommand dscx2 = new SQLiteCommand("select * from 定时消息 where ZT='1'", QL);
                    SQLiteDataReader dscxr = dscx2.ExecuteReader();
                    while (dscxr.Read())
                    {
                        var a = dqsj.AddMinutes(long.Parse(dscxr[3].ToString()));
                        SQLiteCommand dscx3 = new SQLiteCommand("UPDATE 定时消息 set CSH='" + a + "' where id='" + dscxr[0].ToString() + "'", QL);
                        dscx3.ExecuteNonQuery();
                    }
                    CQ.SendPrivateMessage(admin1, String.Format("成功加载{0}个定时消息", i));
                    dsxxkg = 1;
                }
                else
                {
                    dsxxkg = 0;
                }

                SQLiteCommand tpds = new SQLiteCommand("select count(*) from 绿绿联盟列表 where zt='1'", QL);
                int n = int.Parse(tpds.ExecuteScalar().ToString());
                if (n > 0)
                {
                    var b = dqsj.AddMinutes(15);
                    SQLiteCommand tpds2 = new SQLiteCommand("select * from 绿绿联盟列表 where zt='1'", QL);
                    SQLiteDataReader tpds3 = tpds2.ExecuteReader();
                    while (tpds3.Read())
                    {
                        SQLiteCommand tpcf5 = new SQLiteCommand("UPDATE 绿绿联盟列表 set time='" + b + "' where qh='" + tpds3[1].ToString() + "'", QL);
                        tpcf5.ExecuteNonQuery();
                    }
                    tpdskg = 1;
                    CQ.SendPrivateMessage(admin1, String.Format("成功加载{0}个投票惩罚", n));
                }
                else
                {
                    tpdskg = 0;
                }

           }
            catch
            {
                CQ.SendPrivateMessage(admin1, String.Format("加载投票惩罚或定时消息失败"));
            }
            if (jjyc == 0)
            {
                CQ.SendPrivateMessage(admin1, String.Format("基基运行正常 欢迎使用"));
            }
            jtjh = DateTime.Now.ToLongDateString().ToString();
            xq = DateTime.Now.DayOfWeek.ToString();
            day = long.Parse(DateTime.Now.Day.ToString());
            month = int.Parse(DateTime.Now.Month.ToString());
            sz = int.Parse(DateTime.Now.Hour.ToString());
            fz = long.Parse(DateTime.Now.Minute.ToString());
            mz = long.Parse(DateTime.Now.Second.ToString());
        }
        int xyh;
        long lllmqhds;
        //是否为小绿用户
        public int SF(long fromQQ)
        {
            SQLiteCommand sfcz = new SQLiteCommand("select count(*) from kiki_user where QQ = '" + fromQQ + "'", QT);
            if (int.Parse(sfcz.ExecuteScalar().ToString()) > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //留言
        string sj;
        public int LYFK(long fromQQ, string msg)
        {
            sj = jtjh + sz + "时" + fz + "分" + mz + "秒";
            SQLiteCommand lyfk = new SQLiteCommand("INSERT into 留言反馈(id,msg,QQ,Time) VALUES(null,'"+msg+"','"+fromQQ+"','"+sj+"')", QT);
            if (lyfk.ExecuteNonQuery()>0)
            {
                SQLiteCommand hfxh = new SQLiteCommand("select id from 留言反馈 where Time='" + sj + "'", QT);
                return int.Parse(hfxh.ExecuteScalar().ToString());
            }
            else
            {
                return 0;
            }
        }
        public void CC(long fromQQ)
        {
            SQLiteCommand cxlb = new SQLiteCommand("select Green_coin from kiki_user where QQ='" + fromQQ + "'", QT);
             lb = decimal.Parse(cxlb.ExecuteScalar().ToString());
            SQLiteCommand cxlz = new SQLiteCommand("select Green_diamond from kiki_user where QQ='" + fromQQ + "'", QT);
             lz = decimal.Parse(cxlz.ExecuteScalar().ToString());
        }
        //财产修改
        public void CCXG(long fromQQ, long lbkg, decimal xglb, long lzkg, decimal xglz)
        {
            if (lbkg == 1)
            {
                SQLiteCommand xgb = new SQLiteCommand("UPDATE kiki_user set Green_coin='" + xglb + "' where QQ='" + fromQQ + "'", QT);
                if (xgb.ExecuteNonQuery() > 0)
                {
                    xglb = 0;
                }
            }
            if (lzkg == 1)
            {
                SQLiteCommand xgz = new SQLiteCommand("UPDATE kiki_user set Green_diamond='" + xglz + "' where QQ='" + fromQQ + "'", QT);
                if (xgz.ExecuteNonQuery() > 0)
                {
                    xglz = 0;
                }
            }
        }
        decimal lb;
        decimal lz;
        //改名字
        public int GMZ(long fromQQ, string msg,int cg)
        {
            
            if (msg.Length > 10)
            {
                cg = 1;
            }
            else if (msg.Contains(" "))
            {
                cg = 2;
            }
            else
            {
                msg = msg.Replace("'", "xbmjjxbdsb233");
                msg = msg.Replace("\"", "xbmjjxbdsb233");
                msg = msg.Replace(" ", "xbmjjxbdsb233");
                msg = msg.Replace("=", "xbmjjxbdsb233");
                msg = msg.Replace("\\", "xbmjjxbdsb233");
                msg = msg.Replace("/", "xbmjjxbdsb233");
                msg = msg.Replace(".", "xbmjjxbdsb233");
                msg = msg.Replace("#", "xbmjjxbdsb233");
                msg = msg.Replace("*", "xbmjjxbdsb233");
                msg = msg.Replace("+", "xbmjjxbdsb233");
                msg = msg.Replace("-", "xbmjjxbdsb233");
                msg = msg.Replace("基基", "xbmjjxbdsb233");
                if (msg.Contains("xbmjjxbdsb233"))
                {
                    cg = 3;
                }
                else
                {
                    cg = 4;
                }
                
                if (cg == 4)
                {
                    int sf = SF(fromQQ);
                    if (sf == 1)
                    {
                        SQLiteCommand sfbg = new SQLiteCommand("select count(*) from kiki_user where Green_user='" + msg + "'", QL);
                        int m = int.Parse(sfbg.ExecuteScalar().ToString());
                        if (m != 0)
                        {
                            cg = 5;
                        }
                        else
                        {
                            SQLiteCommand gm = new SQLiteCommand("select Green_user from kiki_user where QQ='" + fromQQ + "'", QL);
                            if (gm.ExecuteScalar().ToString() == "")
                            {
                                SQLiteCommand xg = new SQLiteCommand("UPDATE kiki_user set Green_user='" + msg + "' where QQ='" + fromQQ + "'", QL);
                                xg.ExecuteNonQuery();
                                cg = 6;
                            }
                            else
                            {
                                CC(fromQQ);
                                if (lb >= 500)
                                {
                                    lb = lb - 500;
                                    CCXG(fromQQ, 1, lb, 0, lz);

                                    SQLiteCommand xg = new SQLiteCommand("UPDATE kiki_user set Green_user='" + msg + "' where QQ='" + fromQQ + "'", QL);
                                    if (xg.ExecuteNonQuery() > 0)
                                    {
                                        cg = 6;
                                    }
                                }
                                else if (lz >= 10)
                                {
                                    lz = lz - 10;
                                    CCXG(fromQQ, 0, lb, 1, lz);
                                    SQLiteCommand xg = new SQLiteCommand("UPDATE kiki_user set Green_user='" + msg + "' where QQ='" + fromQQ + "'", QL);
                                    if (xg.ExecuteNonQuery() > 0)
                                    {
                                        cg = 6;
                                    }
                                }
                                else
                                {
                                    cg = 9;
                                }
                            }
                        }
                    }
                    else
                    {
                        cg = 8;
                    }
                }
            }
            return cg;
        }
        //基基权限
        int kkqx;
        string xlyhdj;
        public void KKQX(long fromQQ)
        {
            SQLiteCommand cxqg = new SQLiteCommand("select qx from kiki_user where QQ='" + fromQQ + "'", QL);
            kkqx = int.Parse(cxqg.ExecuteScalar().ToString());
            if (kkqx == 0)
            {
                xlyhdj = "小绿注册用户";
            }
            else if (kkqx == 1)
            {
                xlyhdj = "小绿正式用户";
            }
            else if (kkqx == 2)
            {
                xlyhdj = "小绿忠实用户";
            }
            else if (kkqx == 3)
            {
                xlyhdj = "小绿VIP用户";
            }
            else if (kkqx == 5)
            {
                xlyhdj = "绿绿联盟成员";
            }
            else if (kkqx == 6)
            {
                xlyhdj = "绿绿讲师";
            }
            else if (kkqx == 10)
            {
                xlyhdj = "最高管理员";
            }
        }
        string qdgg;
        string cxgg;
        string lczsgg;
        string qdtxgg;
        string rqgg;
        //基基广告
        public void KKGG()
        {
            SQLiteCommand gg1 = new SQLiteCommand("select msg from 功能广告 where gn='1'", QL);
            qdgg = gg1.ExecuteScalar().ToString();
            SQLiteCommand gg2 = new SQLiteCommand("select msg from 功能广告 where gn='2'", QL);
            cxgg = gg2.ExecuteScalar().ToString();
            SQLiteCommand gg3 = new SQLiteCommand("select msg from 功能广告 where gn='3'", QL);
            lczsgg = gg3.ExecuteScalar().ToString();
            SQLiteCommand gg4 = new SQLiteCommand("select msg from 功能广告 where gn='4'", QL);
            qdtxgg = gg4.ExecuteScalar().ToString();
            SQLiteCommand gg5 = new SQLiteCommand("select msg from 功能广告 where gn='5'", QL);
            rqgg = gg5.ExecuteScalar().ToString();
        }
        //结婚情况
        string qgkk;
        long cxdxqq;
        string qgzk;
        string dxnc;
        public void QGZK(long fromQQ)
        {
            SQLiteCommand qgqk = new SQLiteCommand("select qgqk from kiki_user where QQ='" + fromQQ + "'", QL);
            qgzk = qgqk.ExecuteScalar().ToString();
            if (qgzk == "0")
            {
                qgkk = "单身";
            }
            else if (qgzk == "1")
            {
                SQLiteCommand cxqgdx = new SQLiteCommand("select dxQQ from kiki_user where QQ='" + fromQQ + "'", QL);
                cxdxqq = long.Parse(cxqgdx.ExecuteScalar().ToString());
                qgkk = "暗恋中";
            }
            else if (qgzk == "2")
            {
                SQLiteCommand cxqgdx = new SQLiteCommand("select dxQQ from kiki_user where QQ='" + fromQQ + "'", QL);
                cxdxqq = long.Parse(cxqgdx.ExecuteScalar().ToString());
                SQLiteCommand xlyh = new SQLiteCommand("select Green_user from kiki_user where QQ='" + cxdxqq + "'", QL);
                dxnc = xlyh.ExecuteScalar().ToString();
                qgkk = "已婚";
            }
            else if (qgzk == "4")
            {
                qgkk = "保密";
            }
        }
        int qqx;
        //Q群权限
        public void QQQX(long fromQQ, long fromGroup)
        {
            qqx = 0;
            var qqqx = CQ.GetGroupMemberInfo(fromGroup, fromQQ);
            string qqqqx = qqqx.Authority;
            if (qqqqx == "管理员" || qqqqx == "群主")
            {
                qqx = 1;
            }
        }
        //签到
        Random suiji = new Random();
        public void Login(long fromQQ, long fromGroup)
        {
            int sf = SF(fromQQ);
            if (sf == 0)
            {
                SQLiteCommand zc = new SQLiteCommand("INSERT into kiki_user (ID,QQ,Green_user,Green_coin,Green_diamond,Signnum,Signtime,dxQQ,qgqk,qx)VALUES(null,'" + fromQQ + "',null,'50','0','0','新注册','0','0','0')", QL);
                if (zc.ExecuteNonQuery() > 0&&xyh==0)
                {
                    try
                    {
                        YCSJK.Open();
                        MySqlCommand sfcz = new MySqlCommand("select count(*) from user where QQ='" + fromQQ + "'", YCSJK);
                        if (int.Parse(sfcz.ExecuteScalar().ToString())>0)
                        {
                            MySqlCommand lyh = new MySqlCommand("select USER from user where QQ='" + fromQQ + "' ORDER BY Green_diamond DESC,COIN DESC", YCSJK);
                            string yhxm = lyh.ExecuteScalar().ToString();
                            MySqlCommand COIN = new MySqlCommand("select COIN from user where USER='" + yhxm + "'", YCSJK);
                            long llb = long.Parse(COIN.ExecuteScalar().ToString()) / 100;
                            SQLiteCommand xg = new SQLiteCommand("UPDATE kiki_user set Green_user='" + yhxm + "',Green_coin='" + llb + "',qx='1' where QQ='" + fromQQ + "'", QL);
                            if (xg.ExecuteNonQuery() > 0)
                            {
                                CQ.SendGroupMessage(fromGroup, String.Format("好久不见 {0} {1}", yhxm, CQ.CQCode_Face(179)));
                            }
                        }
                        else
                        {
                            CQ.SendGroupMessage(fromGroup, String.Format("终于等到你 还好我没放弃{0}", CQ.CQCode_Face(179)));
                        }
                        YCSJK.Close();
                        YCSJK.Dispose();
                    }
                    catch
                    {
                        YCSJK.Close();
                        YCSJK.Dispose();
                        return;
                    }
                }
            }
            SQLiteCommand sfqd = new SQLiteCommand("select Signtime from kiki_user where QQ='" + fromQQ + "'", QL);
            string scqd = sfqd.ExecuteScalar().ToString();
            if (scqd == jtjh)
            {
                CQ.SendGroupMessage(fromGroup, String.Format("你今天已经签到过了哦~{0}", qdgg));
            }
            else
            {
                long qdpmxh = 0;
                SQLiteCommand qdjl = new SQLiteCommand("INSERT into 签到日志 (id,QQ,Time,TB)VALUES(null,'"+fromQQ+"','"+jtjh+"','0')", QL);
                if (qdjl.ExecuteNonQuery() > 0)
                {
                    SQLiteCommand qdpm = new SQLiteCommand("select count(*) from 签到日志 where Time='"+jtjh+"'", QL);
                    qdpmxh = long.Parse(qdpm.ExecuteScalar().ToString());
                }
                long qdsj = suiji.Next(1,10);
                string ys = "";
                if (qdsj == 1)
                {
                    qdsj = suiji.Next(1, 10);
                }
                if (qdsj == 1)
                {
                    ys = "★☆☆☆☆";
                }
                else if (qdsj == 2 )
                {
                    ys = "★★☆☆☆";
                }
                else if (qdsj == 3)
                {
                    ys = "★★★☆☆";
                }
                else if (qdsj >= 4 && qdsj <= 5)
                {
                    ys = "★★★★☆";
                }
                else if (qdsj>=6)
                {
                    ys = "★★★★★";
                }
                CC(fromQQ);
                SQLiteCommand qdcs = new SQLiteCommand("select Signnum from kiki_user where QQ='" + fromQQ + "'", QL);
                KKQX(fromQQ);
                decimal lzsl = lz;
                long qdcs2 = long.Parse(qdcs.ExecuteScalar().ToString()) + 1;
                decimal qdjb = (lb / 5000 + qdcs2 * qdsj) / 20*617;
                long hddlz = 0;
                long hdlz = 0;
                string hdlzyh = "";
                if (kkqx >= 2)
                {
                    qdjb = qdjb * kkqx;
                    if (kkqx >= 6)
                    {
                        qdjb = qdjb / 3;
                    }
                    hddlz = qdsj * kkqx / 5;
                    hdlz = 1;
                }
                if (qgzk == "2")
                {
                    hddlz = hddlz + (qdsj / 4 + hddlz) / 2;
                    hdlz = 1;
                }
                if (qdjb < 10)
                {
                    qdjb = qdjb + qdsj * 2;
                }
                if (hdlz == 1)
                {
                    hdlz = 0;
                    if (hddlz < 1)
                    {
                        hddlz = 1;
                    }
                    hdlzyh = hddlz + " 绿钻";
                    lzsl = hddlz + lzsl;
                }
                if (month == 6)
                {
                    if (day == 17 && fromGroup == 490392598)
                    {
                        lzsl = lzsl - hddlz;
                        if (sz == 6 || sz == 17)
                        {
                            qdjb = qdjb * 2;
                            hddlz = hddlz * 2;
                        }
                        qdjb = qdjb * 10;
                        if (hddlz == 0)
                        {
                            hddlz = 1;
                        }
                        lzsl = hddlz + lzsl;
                    }
                    else
                    {
                        qdjb = qdjb * 2;
                    }
                }
                else if (month == 7)
                {
                    if (day == 3 && fromGroup == 490392598)
                    {
                        lzsl = lzsl - hddlz;
                        if (sz == 7 || sz == 15)
                        {
                            qdjb = qdjb * 5;
                            hddlz = hddlz * 5;
                        }
                        qdjb = qdjb * 5;
                        hddlz = hddlz * 5;
                        lzsl = hddlz+lzsl;
                    }
                }
                qdjb = Math.Ceiling(qdjb);
                lzsl = Math.Ceiling(lzsl);
                decimal lbzs = Math.Ceiling(lb + qdjb);
                CCXG(fromQQ, 1, lbzs, 1, lzsl);
                lb = 0;
                lz = 0;
                SQLiteCommand tjsj = new SQLiteCommand("UPDATE kiki_user set Signnum='" + qdcs2 + "',Signtime='" + jtjh + "' where QQ='" + fromQQ + "'", QL);
                if (tjsj.ExecuteNonQuery() > 0)
                {
                    SQLiteCommand xlyh = new SQLiteCommand("select Green_user from kiki_user where QQ='" + fromQQ + "'", QL);
                    if (xlyh.ExecuteScalar().ToString() == "")
                    {
                        CQ.SendGroupMessage(fromGroup, String.Format("{0} 签到成功！\n获得 {1} 绿币 {4}\n今日第 {7} 位签到\n运势：{6}\n这是你第 {2} 次签到\n上次签到时间：{3}{5}", CQ.CQCode_At(fromQQ), qdjb, qdcs2, scqd, hdlzyh, qdgg, ys,qdpmxh));
                    }
                    else
                    {
                        CQ.SendGroupMessage(fromGroup, String.Format("亲爱的{4}: {0}\n你本次签到获得:\n{1} 绿币 {5}\n今日第 {8} 位签到\n运势：{7}\n这是你第 {2} 次签到\n上次签到时间：{3}{6}", xlyh.ExecuteScalar().ToString(), qdjb, qdcs2, scqd, xlyhdj, hdlzyh, qdgg, ys,qdpmxh));
                        //帐号升级
                        if (kkqx < 2)
                        {
                            ZHSJ(fromQQ, fromGroup, xlyh.ExecuteScalar().ToString());
                        }
                    }
                    xlyhdj = "";
                    hdlz = 0;
                    hddlz = 0;
                }
            }
        }
        //帐号升级
        public void ZHSJ(long fromQQ, long fromGroup, string yhnc)
        {
            string scfy = "";
            if (jjyc != 2)
            {
                var groupMember = CQ.GetGroupMemberInfo(fromGroup, fromQQ);
                scfy = groupMember.JoinTime.Date.ToString();
            }
            if (scfy == "1970/1/1 0:00:00")
            {
                sjqxkg = 0;
            }
            else
            {
                int day1 = 5;
                int day2 = 0;
                if (jjyc != 2)
                {
                    var groupMember = CQ.GetGroupMemberInfo(490392598, fromQQ);
                    DateTime dat1 = groupMember.JoinTime.Date;
                    DateTime dat2 = groupMember.LastSpeakingTime.Date;
                    DateTime dat3 = DateTime.Now.Date;
                    TimeSpan ts1 = dat3 - dat1;
                    TimeSpan ts2 = dat3 - dat2;
                    day1 = ts1.Days;
                    day2 = ts2.Days;
                }
                if (day2 > 3)
                {
                    sjqxkg = 0;
                }
                else if (day1 < 3)
                {
                    sjqxkg = 0;
                }
                else
                {
                    int sjqx;
                    CC(fromQQ);
                    SQLiteCommand sjqdcs = new SQLiteCommand("select Signnum from kiki_user where QQ='" + fromQQ + "'", QL);
                    long sjqdcsgs = long.Parse(sjqdcs.ExecuteScalar().ToString());
                    if (day1 > 500 && day2 < 1)
                    {
                        sjqx = 2;
                    }
                    else if (day1 > 100 && day2 < 1)
                    {
                        sjqx = 1;
                    }
                    else if (lb >= 500 && sjqdcsgs >= 15)
                    {
                        sjqx = 1;
                    }
                    else if (lb >= 5000 && sjqdcsgs >= 60)
                    {
                        sjqx = 2;
                    }
                    else
                    {
                        sjqx = 0;
                    }
                    if (kkqx >= sjqx)
                    {
                        sjqx = 0;
                    }
                    else
                    {
                        if (sjqx == 2)
                        {
                            if (day1 > 500 && day2 < 1)
                            {
                                day1 = 0;
                                day2 = 2;
                            }
                            else
                            {
                                lb = lb - 3000;
                                CCXG(fromQQ, 1, lb, 0, lz);
                            }
                            SQLiteCommand lyhqx = new SQLiteCommand("UPDATE kiki_user set qx='2' where QQ='" + fromQQ + "'", QL);
                            if (lyhqx.ExecuteNonQuery() > 0)
                            {
                                CQ.SendPrivateMessage(fromQQ, String.Format("恭喜你成功升级为小绿忠实用户！"));
                                CQ.SendGroupMessage(fromGroup, String.Format("恭喜{0}升级为小绿忠实用户！", yhnc));
                            }
                        }
                        else if (sjqx == 1)
                        {
                            SQLiteCommand lyhqx = new SQLiteCommand("UPDATE kiki_user set qx='1' where QQ='" + fromQQ + "'", QL);
                            if (lyhqx.ExecuteNonQuery() > 0)
                            {
                                CQ.SendPrivateMessage(fromQQ, String.Format("恭喜你成功升级为小绿正式用户！"));
                                CQ.SendGroupMessage(fromGroup, String.Format("恭喜{0}升级为小绿正式用户！", yhnc));
                            }
                        }
                    }
                    sjqx = 0;
                }
            }
        }
        //大喇叭
        public void Dlb(string msg)
        {
            //SQLiteCommand dlbb = new SQLiteCommand("select qh from 绿绿联盟列表", QL);
            //SQLiteDataReader dlba = dlbb.ExecuteReader();
            //int a=0;
            //while (dlba.Read())
            //{
            //    if (a <= lllmqhds)
            //    {
            //        CQ.SendGroupMessage(Convert.ToInt64(dlba[0].ToString()), String.Format(msg));
            //        a++;
            //    }
            //}
            foreach (long qh in LLLM)
            {
                CQ.SendGroupMessage(qh, String.Format(msg));
            }
        }
        //骂人模式
        public void Mrmskq(long fromGroup)
        {
            SQLiteCommand mrms = new SQLiteCommand("select answer from qa where priority='76' ORDER BY random() LIMIT 1", ck);
            CQ.SendGroupMessage(fromGroup, String.Format(mrms.ExecuteScalar().ToString()));
        }
        int slkg;
        int qlkg;
        int ggkg;
        int dlb;
        int xlb1;
        int xlb2;
        long lbqh;
        long xghb;
        int glz1;
        int glz2;
        long gqq;
        int mr;
        int zdmr;
       long mrqh;
        long qh;
        int jkxtkg;
       int zsqx;
       int gwx;
       int cxx;
       int kg;
       int xlq;
        long qdtx;
        private int sjqxkg;
        long zczh;
        long xgyhm;
        /// <summary>
        /// Type=21 私聊消息。
        /// </summary>
        /// <param name="subType">子类型，11/来自好友 1/来自在线状态 2/来自群 3/来自讨论组。</param>
        /// <param name="sendTime">发送时间(时间戳)。</param>
        /// <param name="fromQQ">来源QQ。</param>
        /// <param name="msg">消息内容。</param>
        /// <param name="font">字体。</param>
        int hfkg=0;
       long hfxh;
        long slqq;
        public override void PrivateMessage(int subType, int sendTime, long fromQQ, string msg, int font)
        {
            if (xtkg == 0)
            {
                xtkg = 1;
                QL.Open();
                QT.Open();
                ck.Open();
                kqsj = DateTime.Now;
                YCZT();
                shizhong.Elapsed += new System.Timers.ElapsedEventHandler(Timer_TimesUp);
                shizhong.AutoReset = true;
                shizhong.Enabled = true;
                shizhong.Start();
            }
            if (slkg == 0)
            {
                slqq = fromQQ;
                if (msg.Contains("留言") || msg.Contains("改名") || msg.Contains("反馈"))
                {
                    if (slqq < 0)
                    {
                        slqq = slqq + 4294967296;
                    }
                    slkg = 1;
                    if (msg.Contains("留言") || msg.Contains("反馈"))
                    {
                        msg = msg.Replace("留言", "");
                        msg = msg.Replace("反馈", "");
                        if (msg == "")
                        {
                            CQ.SendPrivateMessage(slqq, String.Format("你还没有输入留言内容哦~"));
                        }
                        else
                        {
                            int i = LYFK(slqq, msg);
                            if (i != 0)
                            {
                                CQ.SendPrivateMessage(admin1, String.Format("来自 {0} 的{2}号留言：\n\n{1}\n\n如需回复 请在下方发送 回复{2}", slqq, msg, i));
                                CQ.SendPrivateMessage(admin2, String.Format("来自 {0} 的{2}号留言：\n\n{1}\n\n如需回复 请在下方发送 回复{2}", slqq, msg, i));
                                CQ.SendPrivateMessage(slqq, String.Format("最高管理员已经收到！感谢你的支持，么么哒~"));
                            }
                        }
                        slkg = 0;
                        return;
                    }
                    else if (msg.Contains("改名"))
                    {
                        msg = msg.Replace("改名", "");
                        int cg = GMZ(slqq, msg, 0);
                        if (cg == 1)
                        {
                            CQ.SendPrivateMessage(slqq, String.Format("请勿输入长度大于十内容"));
                        }
                        else if (cg == 2)
                        {
                            CQ.SendPrivateMessage(slqq, String.Format("请不要输入空格"));
                        }
                        else if (cg == 3)
                        {
                            CQ.SendPrivateMessage(slqq, String.Format("检测到所输入内容包含恶意代码 基基已拦截此次请求"));
                        }
                        else if (cg == 5)
                        {
                            CQ.SendPrivateMessage(slqq, String.Format("基基用户库中已存在此用户名\n或是你目前的账号名与要修改的账号名相同\n基基已拦截此次请求 请修改后再试"));
                        }
                        else if (cg == 8)
                        {
                            CQ.SendPrivateMessage(slqq, String.Format("你还未注册小绿账号哦~"));
                        }
                        else if (cg == 6)
                        {
                            CQ.SendPrivateMessage(slqq, String.Format("修改成功！"));
                        }
                        else
                        {
                            CQ.SendPrivateMessage(slqq, String.Format("余额不足 无法修改"));
                        }
                        slkg = 0;
                        return;
                    }
                    slkg = 0;
                }
            }
            if (fromQQ == admin1 || fromQQ == admin2)
            {
                if (msg == "test")
                {
                    YCZT();
                }
                //广告
                if (msg == "清空广告")
                {
                    ggkg = 7;
                }
                if (ggkg != 0)
                {
                    if (ggkg == 1)
                    {
                        SQLiteCommand dlbb = new SQLiteCommand("UPDATE 功能广告 set msg='" + msg + "' where gn='1'", QL);
                        dlbb.ExecuteNonQuery();
                    }
                    else if (ggkg == 2)
                    {
                        SQLiteCommand dlbb = new SQLiteCommand("UPDATE 功能广告 set msg='" + msg + "' where gn='2'", QL);
                        dlbb.ExecuteNonQuery();
                    }
                    else if (ggkg == 3)
                    {
                        SQLiteCommand dlbb = new SQLiteCommand("UPDATE 功能广告 set msg='" + msg + "' where gn='3'", QL);
                        dlbb.ExecuteNonQuery();
                    }
                    else if (ggkg == 4)
                    {
                        SQLiteCommand dlbb = new SQLiteCommand("UPDATE 功能广告 set msg='" + msg + "' where gn='4'", QL);
                        dlbb.ExecuteNonQuery();
                    }
                    else if (ggkg == 5)
                    {
                        SQLiteCommand dlbb = new SQLiteCommand("UPDATE 功能广告 set msg='" + msg + "' where gn='5'", QL);
                        dlbb.ExecuteNonQuery();
                    }
                    else if (ggkg == 6)
                    {
                        SQLiteCommand dlbb1 = new SQLiteCommand("UPDATE 功能广告 set msg='" + msg + "' where gn='1'", QL);
                        dlbb1.ExecuteNonQuery();
                        SQLiteCommand dlbb2 = new SQLiteCommand("UPDATE 功能广告 set msg='" + msg + "' where gn='2'", QL);
                        dlbb2.ExecuteNonQuery();
                        SQLiteCommand dlbb3 = new SQLiteCommand("UPDATE 功能广告 set msg='" + msg + "' where gn='3'", QL);
                        dlbb3.ExecuteNonQuery();
                        SQLiteCommand dlbb4 = new SQLiteCommand("UPDATE 功能广告 set msg='" + msg + "' where gn='4'", QL);
                        dlbb4.ExecuteNonQuery();
                        SQLiteCommand dlbb5 = new SQLiteCommand("UPDATE 功能广告 set msg='" + msg + "' where gn='5'", QL);
                        dlbb5.ExecuteNonQuery();
                    }
                    else if (ggkg == 7)
                    {
                        SQLiteCommand dlbb1 = new SQLiteCommand("UPDATE 功能广告 set msg='' where gn='1'", QL);
                        dlbb1.ExecuteNonQuery();
                        SQLiteCommand dlbb2 = new SQLiteCommand("UPDATE 功能广告 set msg='' where gn='2'", QL);
                        dlbb2.ExecuteNonQuery();
                        SQLiteCommand dlbb3 = new SQLiteCommand("UPDATE 功能广告 set msg='' where gn='3'", QL);
                        dlbb3.ExecuteNonQuery();
                        SQLiteCommand dlbb4 = new SQLiteCommand("UPDATE 功能广告 set msg='' where gn='4'", QL);
                        dlbb4.ExecuteNonQuery();
                        SQLiteCommand dlbb5 = new SQLiteCommand("UPDATE 功能广告 set msg='' where gn='5'", QL);
                        dlbb5.ExecuteNonQuery();
                    }
                    KKGG();
                    ggkg = 0;
                    CQ.SendPrivateMessage(fromQQ, String.Format("修改成功！"));
                    slkg = 0;
                    return;
                }
                if (msg == "签到广告")
                {
                    ggkg = 1;
                    CQ.SendPrivateMessage(fromQQ, String.Format("请输入签到广告内容："));
                }
                if (msg == "查询广告")
                {
                    ggkg = 2;
                    CQ.SendPrivateMessage(fromQQ, String.Format("请输入查询广告内容："));
                }
                if (msg == "冷场助手广告")
                {
                    ggkg = 3;
                    CQ.SendPrivateMessage(fromQQ, String.Format("请输入冷场助手广告内容："));
                }
                if (msg == "签到提醒广告")
                {
                    ggkg = 4;
                    CQ.SendPrivateMessage(fromQQ, String.Format("请输入签到提醒广告内容："));
                }
                if (msg == "入群广告")
                {
                    ggkg = 5;
                    CQ.SendPrivateMessage(fromQQ, String.Format("请输入入群广告内容："));
                }
                if (msg == "全体广告")
                {
                    ggkg = 6;
                    CQ.SendPrivateMessage(fromQQ, String.Format("请输入全体广告内容："));
                }
                //大喇叭
                if (msg == "关闭大喇叭")
                {
                    dlb = 0;
                    CQ.SendPrivateMessage(fromQQ, String.Format("期待你再次使用大喇叭 么么哒~"));
                }
                if (dlb == 1)
                {
                    Dlb(msg);
                    CQ.SendPrivateMessage(fromQQ, String.Format("发送完成！如需继续使用请直接回复内容 如果不需要使用请回复关闭大喇叭："));
                }
                if (msg == "开启大喇叭")
                {
                    dlb = 1;

                    CQ.SendPrivateMessage(fromQQ, String.Format("欢迎使用大喇叭 请在下方输入要发送的内容 基基将推送至所有绿绿联盟群："));
                }
                //喇叭
                if (msg.Contains("关闭小喇叭"))
                {
                    xlb1 = 0;
                    xlb2 = 0;
                    lbqh = 0;
                    CQ.SendPrivateMessage(fromQQ, String.Format("期待你再次使用小喇叭 么么哒~"));
                }
                if (xlb2 == 1)
                {
                    CQ.SendGroupMessage(lbqh, String.Format(msg));
                    CQ.SendPrivateMessage(fromQQ, String.Format("发送成功！\n如需继续在 {0} 群使用请直接回复消息内容\n如果不需要使用或更换其他群请回复 关闭小喇叭", lbqh));
                }
                if (xlb1 == 1)
                {

                    if (!long.TryParse(msg, out lbqh))
                    {
                        CQ.SendPrivateMessage(fromQQ, String.Format("请正确输入群号！"));
                    }
                    else
                    {
                        lbqh = long.Parse(msg);
                        CQ.SendPrivateMessage(fromQQ, String.Format("请输入你要发送的内容："));
                        xlb2 = 1;
                        xlb1 = 0;
                    }
                }
                if (msg.Contains("开启小喇叭"))
                {
                    CQ.SendPrivateMessage(fromQQ, String.Format("尊敬的最高管理员你好！\n请输入你想使用小喇叭的群号："));
                    xlb1 = 1;
                }
                //修改账户
                if (glz2 == 1)
                {
                    if (msg.Contains("绿钻") && msg.Contains("绿币"))
                    {
                        CQ.SendPrivateMessage(fromQQ, String.Format("单次修改只允许一种货币 请重新输入！"));
                    }
                    else if (msg.Contains("绿钻"))
                    {
                        msg = msg.Replace("绿钻", "");
                        if (!long.TryParse(msg, out xghb))
                        {
                            CQ.SendPrivateMessage(fromQQ, String.Format("请不要输入其他字符！"));
                        }
                        else
                        {
                            xghb = long.Parse(msg);
                            CCXG(gqq, 0, 0, 1, xghb);
                            CQ.SendPrivateMessage(fromQQ, String.Format("修改成功！"));
                            glz2 = 0;
                        }
                    }
                    else if (msg.Contains("绿币"))
                    {
                        msg = msg.Replace("绿币", "");
                        if (!long.TryParse(msg, out xghb))
                        {
                            CQ.SendPrivateMessage(fromQQ, String.Format("请不要输入其他字符！"));
                        }
                        else
                        {
                            xghb = long.Parse(msg);
                            CCXG(fromQQ, 1, xghb, 0, xghb);
                            CQ.SendPrivateMessage(fromQQ, String.Format("修改成功！"));
                            glz2 = 0;
                        }
                    }
                }
                if (glz1 == 1)
                {
                    if (!long.TryParse(msg, out gqq))
                    {
                        CQ.SendPrivateMessage(fromQQ, String.Format("请正确输入QQ！"));
                    }
                    else
                    {
                        gqq = long.Parse(msg);
                        int sf = SF(gqq);
                        if (sf == 1)
                        {
                            sf = 0;
                            CC(gqq);
                            CQ.SendPrivateMessage(fromQQ, String.Format("QQ: {0} \n当前拥有:\n绿币:{2}\n绿钻:{1} \n请输入要修改的货币名称+数量(例如 绿钻9998)：", gqq, lz, lb));
                            glz1 = 0;
                            glz2 = 1;
                        }
                        else
                        {
                            CQ.SendPrivateMessage(fromQQ, String.Format("该QQ尚未注册！"));
                        }
                    }
                }
                if (msg == "修改账户")
                {
                    glz1 = 1;
                    CQ.SendPrivateMessage(fromQQ, String.Format("请输入要修改的QQ号："));
                }
                if (msg == "关闭骂人模式")
                {
                    if (mr == 1 || zdmr == 1)
                    {
                        zdmr = 0;
                        mr = 0;
                        CQ.SendPrivateMessage(fromQQ, String.Format("骂人模式关闭惹·-·"));
                    }
                }
                if (hfkg == 1)
                {
                    CQ.SendPrivateMessage(hfxh, String.Format("来自最高管理员的消息内容：\n{0}", msg));
                    CQ.SendPrivateMessage(fromQQ, String.Format("回复成功！"));
                    hfkg = 0;
                }
                if (msg.Contains("回复") && hfkg == 0)
                {
                    msg = msg.Replace("回复", "");
                    if (!long.TryParse(msg, out hfxh))
                    {
                        CQ.SendPrivateMessage(fromQQ, String.Format("请正确输入数字序号!"));
                    }
                    else
                    {
                        SQLiteCommand lycz = new SQLiteCommand("select count(*) from 留言反馈 where id='" + msg + "'", QL);
                        if (int.Parse(lycz.ExecuteScalar().ToString()) > 0)
                        {
                            hfkg = 1;
                            SQLiteCommand hh = new SQLiteCommand("select QQ from 留言反馈 where id='" + msg + "'", QL);
                            hfxh = long.Parse(hh.ExecuteScalar().ToString());
                            CQ.SendPrivateMessage(fromQQ, String.Format("请输入要回复{0}号留言的内容:", msg));
                        }
                        else
                        {
                            CQ.SendPrivateMessage(fromQQ, String.Format("基基留言库中尚未有该条记录 请核对后再试！", msg));
                        }
                    }
                }
                //定时消息
                if (msg.Contains("删除定时"))
                {
                    string dsh = System.Text.RegularExpressions.Regex.Replace(msg, @"[^0-9]+", "");
                    SQLiteCommand scds = new SQLiteCommand("select count(*) from 定时消息 where id='"+dsh+"'",QL);
                    if (int.Parse(scds.ExecuteScalar().ToString()) > 0)
                    {
                        SQLiteCommand sc = new SQLiteCommand("UPDATE 定时消息 set ZT='0' where id='" + dsh + "'", QL);
                        if (sc.ExecuteNonQuery() > 0)
                        {
                            CQ.SendPrivateMessage(fromQQ, String.Format("删除成功！"));
                        }
                    }
                    else
                    {
                        CQ.SendPrivateMessage(fromQQ, String.Format("基基未发现该线程正在使用"));
                    }
                }
                if (msg == "查看所有定时")
                {
                    SQLiteCommand cksyds = new SQLiteCommand("select * from 定时消息 where ZT='1'", QL);
                    SQLiteDataReader dscxr = cksyds.ExecuteReader();
                    string syds = "【定时消息列表】";
                    while (dscxr.Read())
                    {
                        syds = syds + "\n序号：" + dscxr[0].ToString() + "\n内容：" + dscxr[1].ToString() + "\n群号：" + dscxr[2].ToString() + "\n间隔分钟：" + dscxr[3].ToString() + "\n发布者：" + dscxr[5].ToString() + "\n下次时间：" + dscxr[6].ToString();
                    }
                    CQ.SendPrivateMessage(fromQQ, String.Format(syds));
                }
                if (dsxx == 4)
                {
                    dsjgsj = DateTime.Parse(DateTime.Now.ToShortTimeString()).AddMinutes(dssj);
                    if (msg == "是")
                    {
                        SQLiteCommand sfczkz = new SQLiteCommand("select count(*) from 定时消息 where ZT='0'",QL);
                        int sfczdsxx = int.Parse(sfczkz.ExecuteScalar().ToString());
                        if (sfczdsxx > 0)
                        {
                            SQLiteCommand jtkz = new SQLiteCommand("select id from 定时消息 where ZT='0'", QL);
                            int dsxh = int.Parse(sfczkz.ExecuteScalar().ToString());
                            SQLiteCommand dssxx = new SQLiteCommand("UPDATE 定时消息 set msg='"+dsnr+"',QH='"+dsqh+"',JG='"+dssj+"',CF='3',NAME='"+fromQQ+"',CSH='"+ dsjgsj + "',ZT='1' where id='"+dsxh+"'", QL);
                            if (dssxx.ExecuteNonQuery() > 0)
                            {
                                CQ.SendGroupMessage(dsqh, String.Format("{0}", dsnr));
                                CQ.SendPrivateMessage(fromQQ, String.Format("添加成功！"));
                                dsxx = 0;
                                dsqh = 0;
                                dssj = 0;
                                dsnr = "";
                            }
                        }
                        else
                        {
                            SQLiteCommand dssxx = new SQLiteCommand("INSERT into 定时消息 (id,msg,QH,JG,CF,NAME,CSH,ZT) VALUES(null,'" + dsnr + "','" + dsqh + "','" + dssj + "','3','" + fromQQ + "','" + dsjgsj + "','1')", QL);
                            if (dssxx.ExecuteNonQuery() > 0)
                            {
                                CQ.SendGroupMessage(dsqh, String.Format("{0}", dsnr));
                                CQ.SendPrivateMessage(fromQQ, String.Format("添加成功！"));
                                dsxx = 0;
                                dsqh = 0;
                                dssj = 0;
                                dsnr = "";
                            }
                        }
                    }
                    else
                    {
                        SQLiteCommand sfczkz = new SQLiteCommand("select count(*) from 定时消息 where ZT='0'", QL);
                        int sfczdsxx = int.Parse(sfczkz.ExecuteScalar().ToString());
                        if (sfczdsxx > 0)
                        {
                            SQLiteCommand jtkz = new SQLiteCommand("select id from 定时消息 where ZT='0'", QL);
                            int dsxh = int.Parse(sfczkz.ExecuteScalar().ToString());
                            SQLiteCommand dssxx = new SQLiteCommand("UPDATE 定时消息 set msg='" + dsnr + "',QH='" + dsqh + "',JG='" + dssj + "',CF='2',NAME='" + fromQQ + "',CSH='" + dsjgsj + "',ZT='1' where id='" + dsxh + "'", QL);
                            if (dssxx.ExecuteNonQuery() > 0)
                            {
                                CQ.SendPrivateMessage(fromQQ, String.Format("添加成功！"));
                                dsxx = 0;
                                dsqh = 0;
                                dssj = 0;
                                dsnr = "";
                            }
                        }
                        else
                        {
                            SQLiteCommand dssxx = new SQLiteCommand("INSERT into 定时消息 (id,msg,QH,JG,CF,NAME,CSH) VALUES(null,'" + dsnr + "','" + dsqh + "','" + dsjgsj + "','2','" + fromQQ + "','" + dsjgsj + "','1')", QL);
                            if (dssxx.ExecuteNonQuery() > 0)
                            {
                                dsxx = 0;
                                dsqh = 0;
                                dssj = 0;
                                dsnr = "";
                                CQ.SendPrivateMessage(fromQQ, String.Format("添加成功！"));
                            }
                        }
                    }
                    dsxxkg = 1;
                }
                if(dsxx==3)
                {
                    if (!long.TryParse(msg, out dssj))
                    {
                        CQ.SendPrivateMessage(fromQQ, String.Format("请正确输入时间！"));
                    }
                    else
                    {
                        dssj = long.Parse(msg);
                        dsxx = 4;
                        CQ.SendPrivateMessage(fromQQ, String.Format("是否需要循环？"));
                    }
                }
                if (dsxx == 2)
                {
                    dsxx = 3;
                    dsnr = msg;
                    CQ.SendPrivateMessage(fromQQ, String.Format("请输入时间：（单位分钟）"));
                }
                if (dsxx == 1)
                {
                    if (!long.TryParse(msg, out dsqh))
                    {
                        CQ.SendPrivateMessage(fromQQ, String.Format("请正确输入数字群号!"));
                    }
                    else
                    {
                        dsxx = 2;
                        dsqh = long.Parse(msg);
                        CQ.SendPrivateMessage(fromQQ, String.Format("请输入消息内容："));
                    }
                }
                if (msg == "定时消息"&&dsxx==0)
                {
                    CQ.SendPrivateMessage(fromQQ, String.Format("欢迎使用基基的定时消息！\n暂时只支持文本消息 如需发送表情等请使用小喇叭或大喇叭发送~"));
                    CQ.SendPrivateMessage(fromQQ, String.Format("请输入你想使用的群号："));
                    dsxx = 1;
                }
            }
        }
        int dsxx=0;
        long dsqh;
        long dssj;
        string dsnr;
        #endregion

        #region youxi
        public int Game(long fromQQ)
        {
            SQLiteCommand sfcz = new SQLiteCommand("select count(*) from kiki_user where QQ = '" + fromQQ + "'", YX);
            if (int.Parse(sfcz.ExecuteScalar().ToString()) > 0)
            {
                SQLiteCommand xbxz = new SQLiteCommand("select 系别 from kiki_user where QQ = '" + fromQQ + "'", YX);
                if (xbxz.ExecuteScalar().ToString()!="")
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }
        public void ZL(long fromQQ, int fs)
        {
            SQLiteCommand yxzl = new SQLiteCommand("select * from kiki_user where QQ='" + qlqq + "'", YX);
            SQLiteDataReader yxzl2 = yxzl.ExecuteReader();
            if (yxzl2.Read())
            {
                if (fs == 0)
                {
                    CQ.SendPrivateMessage(fromQQ, String.Format("{0} {14}的游戏资料：\n等级：{1} 系别：{2}\n生命值：{3}\n攻击力：{4} 防御力：{5}\n命中率：{6} 暴击率：{7}\n致命一击/绝对防御：{8}\n法力值恢复率：{9}\n经验值：{10}\n宠物：{11} 坐骑：{12}\n疲劳度：{13}", CQ.CQCode_At(fromQQ), yxzl2[18], yxzl2[21], yxzl2[11], yxzl2[12], yxzl2[13], yxzl2[14], yxzl2[15], yxzl2[16], yxzl2[19], yxzl2[18], yxzl2[22], yxzl2[23], yxzl2[25], yxzl2[26]));
                }
                else
                {
                    CQ.SendGroupMessage(fromQQ, String.Format("{0} {14}的游戏资料：\n等级：{1} 系别：{2}\n生命值：{3}\n攻击力：{4} 防御力：{5}\n命中率：{6} 暴击率：{7}\n致命一击/绝对防御：{8}\n法力值恢复率：{9}\n经验值：{10}\n宠物：{11} 坐骑：{12}\n疲劳度：{13}", CQ.CQCode_At(fromQQ), yxzl2[18], yxzl2[21], yxzl2[11], yxzl2[12], yxzl2[13], yxzl2[14], yxzl2[15], yxzl2[16], yxzl2[19], yxzl2[18], yxzl2[22], yxzl2[23], yxzl2[25], yxzl2[26]));
                }
            }
            
        }
        #endregion
        /// <summary>
        /// Type=2 群消息。
        /// </summary>
        /// <param name="subType">子类型，目前固定为1。</param>
        /// <param name="sendTime">发送时间(时间戳)。</param>
        /// <param name="fromGroup">来源群号。</param>
        /// <param name="fromQQ">来源QQ。</param>
        /// <param name="fromAnonymous">来源匿名者。</param>
        /// <param name="msg">消息内容。</param>
        /// <param name="font">字体。</param>
        /// 
        long qlqq;
        long qlqh;
        long dzqh;
        int rqday;
        long fqdz;
        int dzjd;
        long csf;
        public override void GroupMessage(int subType, int sendTime, long fromGroup, long fromQQ, string fromAnonymous, string msg, int font)
        {
            if (xtkg == 0)
            {
                xtkg = 1;
                QL.Open();
                QT.Open();
                ck.Open();
                kqsj = DateTime.Now;
                YCZT();
                shizhong.Elapsed += new System.Timers.ElapsedEventHandler(Timer_TimesUp);
                shizhong.AutoReset = true;
                shizhong.Enabled = true;
                shizhong.Start();
            }
            if (fromQQ == admin1 || fromQQ == admin2)
            {
                if (msg == "关闭群管")
                {
                    qlkg = 1;
                    zdmr = 0;
                    mr = 0;
                    gwx = 0;
                    zsqx = 0;
                    jkxtkg = 0;
                    CQ.SendGroupMessage(fromGroup, String.Format("好的QAQ"));
                }
                if (msg == "开启群管")
                {
                    qlkg = 0;
                    CQ.SendGroupMessage(fromGroup, String.Format("我肥来啦·-·"));
                }
                if (msg.Contains("强制改名"))
                {
                    string gm;
                    msg = msg.Replace("强制改名", "");
                    gm = System.Text.RegularExpressions.Regex.Replace(msg, @"[^0-9]+", "");
                    if (gm == "")
                    {
                        CQ.SendGroupMessage(qlqh, String.Format("请输入正确的QQ号！"));
                    }
                    else
                    {
                        msg = msg.Replace(gm, "");
                        msg = msg.Replace("[CQ:at,qq=", "");
                        msg = msg.Replace("]", "");
                        msg = msg.Replace(" ", "");
                        int sf2 = SF(long.Parse(gm));
                        if (sf2 == 1)
                        {
                            SQLiteCommand xg = new SQLiteCommand("UPDATE kiki_user set Green_user='" + msg + "' where QQ='" + gm + "'", QL);
                            if (xg.ExecuteNonQuery() > 0)
                            {
                                if (jjyc != 2)
                                {
                                    CQ.SetGroupNickName(fromGroup, long.Parse(gm), msg);
                                }
                                CQ.SendGroupMessage(fromGroup, String.Format("修改成功！"));
                            }
                        }
                        else
                        {
                            CQ.SendGroupMessage(fromQQ, String.Format("该QQ尚未注册！"));
                        }
                    }
                    return;
                }
                if (msg.Contains("升级")|| msg.Contains("降级"))
                {                   
                    string sj;
                    sj = System.Text.RegularExpressions.Regex.Replace(msg, @"[^0-9]+", "");
                    if (sj == "")
                    {
                        CQ.SendGroupMessage(qlqh, String.Format("请输入正确的QQ号！"));
                    }
                    else
                    {
                        int sf = SF(long.Parse(sj));
                        if (sf == 1)
                        {
                            KKQX(long.Parse(sj));
                            int qx = 0;
                            if (msg.Contains("升级"))
                            {
                                if (kkqx == 0)
                                {
                                    qx = 1;
                                }
                                else if (kkqx == 1)
                                {
                                    qx = 2;
                                }
                                else if (kkqx == 2)
                                {
                                    qx = 5;
                                }
                                else if (kkqx == 5)
                                {
                                    qx = 6;
                                }
                                else
                                {
                                    CQ.SendGroupMessage(fromQQ, String.Format("升级失败 已达到当前开放等级极限！"));
                                    return;
                                }
                                SQLiteCommand lyhqx = new SQLiteCommand("UPDATE kiki_user set qx='"+qx+"' where QQ='" + sj + "'", QL);
                                if (lyhqx.ExecuteNonQuery() > 0)
                                {
                                    CQ.SendGroupMessage(fromGroup, String.Format("恭喜{0}通过py交易升级！", sj));
                                }
                            }
                            else
                            {
                                if (kkqx == 6)
                                {
                                    qx = 5;
                                }
                                else if (kkqx == 1)
                                {
                                    qx = 0;
                                }
                                else if (kkqx == 2)
                                {
                                    qx = 1;
                                }
                                else if (kkqx == 5)
                                {
                                    qx = 2;
                                }
                                else
                                {
                                    CQ.SendGroupMessage(fromQQ, String.Format("降级失败 已达到当前开放等级极限！"));
                                    return;
                                }
                                SQLiteCommand lyhqx = new SQLiteCommand("UPDATE kiki_user set qx='" + qx + "' where QQ='" + sj + "'", QL);
                                if (lyhqx.ExecuteNonQuery() > 0)
                                {
                                    CQ.SendGroupMessage(fromGroup, String.Format("{0}惹怒了最高管理员被降级！", sj));
                                }
                            }
                        }
                        else
                        {
                            CQ.SendGroupMessage(fromQQ, String.Format("该QQ尚未注册！"));
                        }
                    }
                }
                if (msg == "运行时间")
                {
                    DateTime  yxsj = DateTime.Now;
                    TimeSpan yxsjjg = yxsj - kqsj;
                    double yxsjsc = yxsjjg.TotalSeconds;
                    sj = jtjh + sz + "时" + fz + "分" + mz + "秒";
                    CQ.SendGroupMessage(fromGroup, String.Format("【运行时间】\n基基本次已运行{0}秒\n基基系统时间：{1}\n服务器时间：{2}", yxsjsc,sj, yxsj));
                }
                if (msg == "关闭骂人模式")
                {
                    if (mr == 1 || zdmr == 1)
                    {
                        zdmr = 0;
                        mr = 0;
                        CQ.SendGroupMessage(fromGroup, String.Format("骂人模式关闭惹·-·"));
                    }
                }
                if (msg == "关闭跟我学" && gwx == 1)
                {
                    if (zsqx == 1 && fromQQ == admin2)
                    {
                        CQ.SendGroupMessage(fromGroup, String.Format("最高管理员 岁陌 正在使用\n请您等待他关闭本功能后使用"));
                    }
                    else
                    {
                        gwx = 0;
                        zsqx = 0;
                        CQ.SendGroupMessage(fromGroup, String.Format("QAQ"));
                    }
                }
                if (gwx == 1 && fromQQ == admin1)
                {
                    CQ.SendGroupMessage(fromGroup, String.Format(msg));
                }
                if (gwx == 1 && fromQQ == admin2)
                {
                    if (zsqx != 1)
                    {
                        CQ.SendGroupMessage(fromGroup, String.Format(msg));
                    }
                }
                if (msg == "开启跟我学")
                {
                    if (zsqx == 1)
                    {
                        CQ.SendGroupMessage(fromGroup, String.Format("最高管理员 岁陌 正在使用\n请您等待他关闭本功能后使用"));
                    }
                    else
                    {
                        gwx = 1;
                        if (fromQQ == admin1)
                        {
                            zsqx = 1;
                        }
                        CQ.SendGroupMessage(fromGroup, String.Format("QWQ"));
                    }
                }
                if (msg == "加入绿绿联盟")
                {
                    SQLiteCommand lllm = new SQLiteCommand("select count(*) from 绿绿联盟列表 where qh='" + fromGroup + "'", QL);
                    int lllmcz = int.Parse(lllm.ExecuteScalar().ToString());
                    if (lllmcz > 0)
                    {
                        CQ.SendGroupMessage(fromGroup, String.Format("本群已加入绿绿联盟"));
                    }
                    else
                    {
                        SQLiteCommand sfczk = new SQLiteCommand("select count(*) from 绿绿联盟列表 where qh='0'", QL);
                        int sfczkk = int.Parse(sfczk.ExecuteScalar().ToString());
                        if (sfczkk > 0)
                        {
                            SQLiteCommand ldid = new SQLiteCommand("select id from 绿绿联盟列表 where qh='0'", QL);
                            int ldidd = int.Parse(ldid.ExecuteScalar().ToString());
                            SQLiteCommand tjid = new SQLiteCommand("UPDATE 绿绿联盟列表 set qh='" + fromGroup + "' where id='" + ldidd + "'", QL);
                            if (tjid.ExecuteNonQuery() > 0)
                            {
                                CQ.SendGroupMessage(fromGroup, String.Format("加入成功！"));
                            }
                        }
                        else
                        {
                            SQLiteCommand zc = new SQLiteCommand("INSERT into 绿绿联盟列表(id,qh)VALUES(null,'" + fromGroup + "')", QL);
                            if (zc.ExecuteNonQuery() > 0)
                            {
                                CQ.SendGroupMessage(fromGroup, String.Format("加入成功！"));
                            }
                        }
                        LLLM.Clear();
                        SQLiteCommand lllm1 = new SQLiteCommand("select qh from 绿绿联盟列表", QL);
                        SQLiteDataReader lllm2 = lllm1.ExecuteReader();
                        while (lllm2.Read())
                        {
                            LLLM.Add(Convert.ToInt64(lllm2[0].ToString()));
                        }
                    }
                }
                if (msg == "退出绿绿联盟")
                {
                    SQLiteCommand lllm = new SQLiteCommand("select count(*) from 绿绿联盟列表 where qh='" + fromGroup + "'", QL);
                    int lllmcz = int.Parse(lllm.ExecuteScalar().ToString());
                    if (lllmcz > 0)
                    {
                        SQLiteCommand ldid = new SQLiteCommand("select id from 绿绿联盟列表 where qh='" + fromGroup + "'", QL);
                        int ldidd = int.Parse(ldid.ExecuteScalar().ToString());
                        SQLiteCommand tjid = new SQLiteCommand("UPDATE 绿绿联盟列表 set qh='0' where id='" + ldidd + "'", QL);
                        if (tjid.ExecuteNonQuery() > 0)
                        {
                            CQ.SendGroupMessage(fromGroup, String.Format("退出成功！"));
                        }
                        LLLM.Clear();
                        SQLiteCommand lllm1 = new SQLiteCommand("select qh from 绿绿联盟列表", QL);
                        SQLiteDataReader lllm2 = lllm1.ExecuteReader();
                        while (lllm2.Read())
                        {
                            LLLM.Add(Convert.ToInt64(lllm2[0].ToString()));
                        }
                    }
                    else
                    {
                        CQ.SendGroupMessage(fromGroup, String.Format("本群尚未加入绿绿联盟"));
                    }
                }
                if (msg == "开启骂人模式" && zdmr != 1)
                {
                    mrqh = fromGroup;
                    mr = 1;
                    CQ.SendGroupMessage(fromGroup, String.Format("骂人模式开启啦·-·"));
                }
                if (msg == "开启自动骂人模式" && mr != 1)
                {
                    zdmr = 1;
                    mrqh = fromGroup;
                    CQ.SendGroupMessage(fromGroup, String.Format("自动骂人模式开启啦·-·"));
                }
                if (msg .Contains("妹纸名单"))
                {
                    if (msg.Contains("本群"))
                    {
                        SQLiteCommand mzmd = new SQLiteCommand("select count(*) from 妹纸 where QH='" + fromGroup + "'", QL);
                        if (int.Parse(mzmd.ExecuteScalar().ToString()) > 0)
                        {
                            SQLiteCommand mzjtmz = new SQLiteCommand("select QQ from 妹纸 where QH='" + fromGroup + "'", QL);
                            SQLiteDataReader mzlb = mzjtmz.ExecuteReader();
                            string mzqq = "";
                            while (mzlb.Read())
                            {
                                mzqq = mzqq + mzlb[0].ToString() + "\n";
                            }
                            CQ.SendGroupMessage(fromGroup, String.Format("【本群妹纸名单】\n\n{0}{1}", mzqq, qdgg));
                        }
                        else
                        {
                            CQ.SendGroupMessage(fromGroup, String.Format("基基在本群还没有发现妹纸哦~"));
                        }
                    }
                    else if(msg.Contains("全体"))
                    {
                        SQLiteCommand mzjtmz = new SQLiteCommand("select QQ from 妹纸", QL);
                        SQLiteDataReader mzlb = mzjtmz.ExecuteReader();
                        string mzqq = "";
                        while (mzlb.Read())
                        {
                            mzqq = mzqq + mzlb[0].ToString() + "\n";
                        }
                        CQ.SendGroupMessage(fromGroup, String.Format("【妹纸名单】\n\n{0}{1}", mzqq, qdgg));
                    }
                }
            }
            if (jkxtkg == 1 && LLLM.Contains(fromGroup))
            {
                    DateTime jkxt = DateTime.Parse(DateTime.Now.ToLongTimeString());
                    TimeSpan jkmr = DateTime.Parse("06:00:00") - jkxt;
                    long jgsj = Convert.ToInt64(jkmr.TotalSeconds);
                    long id = suiji.Next(1, 6);
                    SQLiteCommand aywh = new SQLiteCommand("select msg from 熬夜提醒 where id='" + id + "'", QL);
                    CQ.SetGroupMemberGag(fromGroup, fromQQ, jgsj);
                    CQ.SendGroupMessage(fromGroup, String.Format("【基基温馨提醒】\n{0}{1}\n为了你的身心健康，请合理安排时间，享受健康生活。", CQ.CQCode_At(fromQQ), aywh.ExecuteScalar()));
                    return;
            }
            if (qlkg == 0)
            {
                qlqq = fromQQ;
                qlqh = fromGroup;
                if (mr == 1 && qlqh == mrqh)
                {
                    Mrmskq(mrqh);
                    return;
                }
                if(qlqq == 80000000)
                {
                    return;
                }
                #region 群管
                else if (msg.Contains("留言") || msg.Contains("改名") || msg == "签到" || msg == "冒泡" || msg.Contains("sign") || msg == "簽到" || msg.Contains("查询") || msg == "信息" || msg.Contains("管理员给我来个") || msg.Contains("基基给我来个") || msg.Contains("查消息") || msg.Contains("动态惩罚") || msg == "召唤老婆" || msg.Contains("我老婆") || msg == "召唤老公" || msg.Contains("我老公") || msg.Contains("我要结婚") || msg == "我要离婚" || msg.Contains("投票惩罚")|| msg == "资料")
                {
                    if (qlqq < 0)
                    {
                        qlqq = qlqq + 4294967296;
                    }
                    qlkg = 1;
                    if (qlqq== 80000000)
                    {
                        CQ.SendGroupMessage(qlqh, String.Format("不理你 哼"));
                        qlkg = 0;
                        return;
                    }
                    else if (msg.Contains("留言"))
                    {
                        msg = msg.Replace("留言", "");
                        msg = msg.Replace("反馈", "");
                        if (msg == "")
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("你还没有输入留言内容哦~"));
                        }
                        else
                        {
                            int i = LYFK(qlqq, msg);
                            if (i != 0)
                            {
                                CQ.SendPrivateMessage(admin1, String.Format("来自 {0} 的{2}号留言：\n\n{1}\n如需回复 请在下方发送 回复{2}", qlqq, msg, i));
                                CQ.SendPrivateMessage(admin2, String.Format("来自 {0} 的{2}号留言：\n\n{1}\n如需回复 请在下方发送 回复{2}", qlqq, msg, i));
                                CQ.SendGroupMessage(qlqh, String.Format("最高管理员已经收到！感谢你的支持，么么哒~"));
                            }
                        }
                        qlkg = 0;
                        return;
                    }
                    else if (msg.Contains("改名"))
                    {
                        msg = msg.Replace("改名", "");
                        int cg = GMZ(qlqq, msg, 0);
                        if (cg == 1)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("请勿输入长度大于十内容"));
                        }
                        else if (cg == 2)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("请不要输入空格"));
                        }
                        else if (cg == 3)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("检测到所输入内容包含恶意代码 基基已拦截此次请求"));
                        }
                        else if (cg == 5)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("基基用户库中已存在此用户名\n或是你目前的账号名与要修改的账号名相同\n基基已拦截此次请求 请修改后再试"));
                        }
                        else if (cg == 8)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("你还未注册小绿账号哦~"));
                        }
                        else if (cg == 6)
                        {
                            if (jjyc != 2)
                            {
                                CQ.SetGroupNickName(qlqh, qlqq, msg);
                            }
                            CQ.SendGroupMessage(qlqh, String.Format("修改成功！"));
                        }
                        else
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("余额不足 无法修改"));
                        }
                        qlkg = 0;
                        return;
                    }
                    else if (msg == "签到" || msg == "冒泡" || msg.Contains("sign") || msg == "簽到")
                    {
                        if (sz > 5 || xq == "Sunday" || xq == "Saturday")
                        {
                            Login(qlqq, qlqh);
                        }
                        else
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("现在已经{0}点了哦~ 早点睡觉\n6点以后再来找基基玩把qwq\nPS:基基签到算法无排名增益 放心大胆的睡觉吧！", sz));
                        }
                        qlkg = 0;
                        return;
                    }
                    else if (msg == "查询" || msg == "信息"|| msg == "资料")
                    {
                        int sf = SF(qlqq);
                        if (sf == 0)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("你还未注册小绿账号！\n快发句 签到\n基基将自动帮你注册账号{0}{1}", CQ.CQCode_Face(178), cxgg));
                        }
                        else
                        {
                            KKQX(qlqq);
                            CC(qlqq);
                            QGZK(qlqq);
                            SQLiteCommand xlyh = new SQLiteCommand("select Green_user from kiki_user where QQ='" + qlqq + "'", QL);
                            SQLiteCommand qdcs = new SQLiteCommand("select Signnum from kiki_user where QQ='" + qlqq + "'", QL);
                            string qdzs = qdcs.ExecuteScalar().ToString();
                            SQLiteCommand scqd = new SQLiteCommand("select Signtime from kiki_user where QQ='" + qlqq + "'", QL);
                            string scqdsj = scqd.ExecuteScalar().ToString();
                            if (xlyh.ExecuteScalar().ToString() == "")
                            {
                                CQ.SendGroupMessage(qlqh, String.Format("{0}\n你的个人资料：\n绿币：{1}\n绿钻：{4} \n签到次数：{2}\n上次签到时间：{3}{5}", CQ.CQCode_At(qlqq), lb, qdzs, scqdsj, lz, cxgg));
                            }
                            else
                            {
                                if (qgkk == "已婚")
                                {
                                    CQ.SendGroupMessage(qlqh, String.Format("{5}\n亲爱的{6}: {0} \n你的个人资料：\n绿币：{1}\n绿钻：{4} \n签到次数：{2}\n上次签到时间：{3}\n情感状况：已婚({7}){8}", xlyh.ExecuteScalar().ToString(), lb, qdzs, scqdsj, lz, CQ.CQCode_At(qlqq), xlyhdj, dxnc, cxgg));
                                }
                                else
                                {
                                    CQ.SendGroupMessage(qlqh, String.Format("{5}\n亲爱的{6}: {0} \n你的个人资料：\n绿币：{1}\n绿钻：{4} \n签到次数：{2}\n上次签到时间：{3}\n情感状况：{7}{8}", xlyh.ExecuteScalar().ToString(), lb, qdzs, scqdsj, lz, CQ.CQCode_At(qlqq), xlyhdj, qgkk, cxgg));
                                }
                            }
                            kkqx = 0;
                            qgkk = "";
                        }
                        qlkg = 0;
                        return;
                    }
                    else if (msg.Contains("查询"))
                    {
                        string cxqq = System.Text.RegularExpressions.Regex.Replace(msg, @"[^0-9]+", "");
                        if (cxqq != "")
                        {
                            if (jjyc == 2)
                            {
                                CQ.SendGroupMessage(qlqh, String.Format("检测到基基当前为非正常模式 暂时无法获取Q群权限 仅获取基基用户权限\n如有疑问请联系{0}或发送留言", admin2));
                            }
                            else
                            {
                                QQQX(qlqq, qlqh);
                            }
                            int sf = SF(qlqq);
                            if (sf == 1)
                            {
                                KKQX(qlqq);
                            }
                            if (qqx == 1 || kkqx >= 5)
                            {

                                qqx = 0;
                                kkqx = 0;
                                long cxdrqq = long.Parse(cxqq);
                                int sf2 = SF(cxdrqq);
                                if (sf2 == 0)
                                {
                                    CQ.SendGroupMessage(qlqh, String.Format("该QQ尚未注册基基数据库哦~请核对后再试"));
                                }
                                else
                                {
                                    KKQX(cxdrqq);
                                    CC(cxdrqq);
                                    QGZK(cxdrqq);
                                    SQLiteCommand xlyh = new SQLiteCommand("select Green_user from kiki_user where QQ='" + cxdrqq + "'", QL);
                                    SQLiteCommand qdcs = new SQLiteCommand("select Signnum from kiki_user where QQ='" + cxdrqq + "'", QL);
                                    string qdzs = qdcs.ExecuteScalar().ToString();
                                    SQLiteCommand scqd = new SQLiteCommand("select Signtime from kiki_user where QQ='" + cxdrqq + "'", QL);
                                    string scqdsj = scqd.ExecuteScalar().ToString();
                                    if (xlyh.ExecuteScalar().ToString() == "")
                                    {
                                        CQ.SendGroupMessage(qlqh, String.Format("{0}\nQQ：{5}\n绿币：{1}\n绿钻：{4} \n签到次数：{2}\n上次签到时间：{3}", CQ.CQCode_At(qlqq), lb, qdzs, scqdsj, lz, cxdrqq));
                                    }
                                    else
                                    {
                                        if (qgkk == "已婚")
                                        {
                                            CQ.SendGroupMessage(qlqh, String.Format("{5}\n{6}: {0} \n绿币：{1}\n绿钻：{4} \n签到次数：{2}\n上次签到时间：{3}\n情感状况：已婚({7})", xlyh.ExecuteScalar().ToString(), lb, qdzs, scqdsj, lz, CQ.CQCode_At(qlqq), xlyhdj, dxnc));
                                        }
                                        else
                                        {
                                            CQ.SendGroupMessage(qlqh, String.Format("{5}\n{6}: {0} \n绿币：{1}\n绿钻：{4} \n签到次数：{2}\n上次签到时间：{3}\n情感状况：{7}", xlyh.ExecuteScalar().ToString(), lb, qdzs, scqdsj, lz, CQ.CQCode_At(qlqq), xlyhdj, qgkk));
                                        }
                                    }
                                    qgkk = "";
                                }
                            }
                            else
                            {
                                CQ.SendGroupMessage(qlqh, String.Format("权限不足 无法使用"));
                            }
                            qlkg = 0;
                            return;
                        }
                    }
                    //禁言套餐
                    else if (msg.Contains("管理员给我来个") || msg.Contains("基基给我来个"))
                    {
                        if (jjyc == 2)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("检测到基基当前为非正常模式 暂时无法使用禁言套餐\n如有疑问请联系{0}或发送留言", admin2));
                            qlkg = 0;
                            return;
                        }
                        if (msg.Contains("的禁言套餐"))
                        {
                            QQQX(dlqq, qlqh);
                            if (qqx == 1)
                            {
                                qqx = 0;
                                QQQX(qlqq, qlqh);
                                if (qqx == 1)
                                {
                                    qqx = 0;
                                    CQ.SendGroupMessage(qlqh, String.Format("你是管理员或是群主哦~基基无法禁言你哦~"));
                                }
                                else
                                {
                                    msg = msg.Replace("管理员给我来个", "");
                                    msg = msg.Replace("基基给我来个", "");
                                    msg = msg.Replace("的禁言套餐", "");
                                    string jyyy = msg;
                                    string jysj;
                                    jysj = System.Text.RegularExpressions.Regex.Replace(msg, @"[^0-9]+", "");
                                    if (jysj == "")
                                    {
                                        CQ.SendGroupMessage(qlqh, String.Format("你没有输入时间哦~\n基基暂不支持中文数字"));
                                    }
                                    else if (long.Parse(jysj) > 2592000 || long.Parse(jysj) < 1)
                                    {
                                        CQ.SendGroupMessage(qlqh, String.Format("请输入正确的时间"));
                                    }
                                    else
                                    {
                                        msg = msg.Replace(jysj, "");
                                        long cs = 1;
                                        switch (msg)
                                        {
                                            case "s": cs = 1; break;
                                            case "秒": cs = 1; break;
                                            case "分钟": cs = 60; break;
                                            case "m": cs = 60; break;
                                            case "小时": cs = 3600; break;
                                            case "h": cs = 3600; break;
                                            case "天": cs = 86400; break;
                                            case "d": cs = 86400; break;
                                        }
                                        long tc = long.Parse(jysj) * cs;
                                        if (tc > 2592000 || tc < 1)
                                        {
                                            CQ.SendGroupMessage(qlqh, String.Format("时间超出QQ支持的最大范围 快点重新输"));
                                        }
                                        else
                                        {
                                            CQ.SetGroupMemberGag(qlqh, qlqq, tc);
                                            CQ.SendGroupMessage(qlqh, String.Format("恭喜你获得了来自本宝宝赐予的 {0} 的禁言套餐", jyyy));
                                        }
                                    }
                                }
                            }
                            else
                            {
                                CQ.SendGroupMessage(qlqh, String.Format("基基不是管理员噢~"));
                            }
                        }
                        else
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("格式不对哦~"));
                        }
                        qlkg = 0;
                        return;
                    }
                    //查消息
                    else if (msg.Contains("查消息"))
                    {
                        int sf = SF(qlqq);
                        if (sf == 1)
                        {
                            KKQX(qlqq);
                        }
                        if (jjyc == 2)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("检测到基基当前为非正常模式 暂时无法获取Q群权限 仅获取基基用户权限\n如有疑问请联系{0}或发送留言", admin2));
                        }
                        else
                        {
                            QQQX(qlqq, qlqh);
                        }
                        if (qqx == 1 || kkqx >= 5)
                        {
                            qqx = 0;
                            kkqx = 0;
                            msg = msg.Replace("查消息", "");
                            string xxs;
                            xxs = System.Text.RegularExpressions.Regex.Replace(msg, @"[^0-9]+", "");
                            if (xxs == "")
                            {
                                CQ.SendGroupMessage(qlqh, String.Format("请输入自基基本条消息以上的正常消息数字序号！"));
                                cxx = 0;
                            }
                            else
                            {
                                long xxss = long.Parse(xxs) + 1;
                                if (xxss <= 0)
                                {
                                    CQ.SendGroupMessage(qlqh, String.Format("请输入自基基本条消息以上的正常消息数字序号！"));
                                    cxx = 0;
                                }
                                else
                                {
                                    SQLiteConnection chehui = new SQLiteConnection("Data Source=data/" + dlqq + "/eventv2.db;Pooling=true;FailIfMissing=false;");
                                    chehui.Open();
                                    SQLiteCommand xxzs = new SQLiteCommand("select count(*) from event where \"group\" ='" + "qq/group/" + qlqh + "'", chehui);
                                    long djtxx = long.Parse(xxzs.ExecuteScalar().ToString());
                                    if (xxss > djtxx)
                                    {
                                        CQ.SendGroupMessage(qlqh, String.Format("基基目前仅记录了本群包括本条消息在内的{0}条消息\n如需更多消息请自行使用消息记录进行查找", djtxx + 1));
                                    }
                                    else
                                    {
                                        SQLiteCommand qq = new SQLiteCommand("select account from event where \"group\" ='" + "qq/group/" + qlqh + "' order by id desc LIMIT '" + xxss + "','1'", chehui);
                                        string qqh = qq.ExecuteScalar().ToString();
                                        qqh = qqh.Replace("qq/user/", "");
                                        SQLiteCommand cx = new SQLiteCommand("select cast(content as text) from event where \"group\" ='" + "qq/group/" + qlqh + "' order by id desc LIMIT '" + xxss + "','1'", chehui);
                                        if (qqh == "")
                                        {
                                            CQ.SendGroupMessage(qlqh, String.Format("这条消息是基基发的哦~查你个头"));
                                        }
                                        else
                                        {
                                            CQ.SendGroupMessage(qlqh, String.Format("来自 {1} 的消息内容：\n{0}", cx.ExecuteScalar().ToString(), CQ.CQCode_At(long.Parse(qqh))));
                                        }
                                    }
                                    chehui.Close();
                                    chehui.Dispose();
                                    cxx = 0;
                                }
                            }
                        }
                        else
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("你的权限不够哦~"));
                            cxx = 0;
                        }
                        qlkg = 0;
                        return;
                    }
                    //动态惩罚
                    else if (msg.Contains("动态惩罚"))
                    {
                        if (jjyc == 2)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("检测到基基当前为非正常模式 暂时无法获取Q群权限 仅获取基基用户权限\n如有疑问请联系{0}或发送留言", admin2));
                        }
                        else
                        {
                            QQQX(qlqq, qlqh);
                        }
                        int sf = SF(qlqq);
                        if (sf == 1)
                        {
                            KKQX(qlqq);
                        }
                        if (qqx == 1 || kkqx >= 5)
                        {
                            sf = 0;
                            qqx = 0;
                            kkqx = 0;
                            string qq;
                            qq = System.Text.RegularExpressions.Regex.Replace(msg, @"[^0-9]+", "");
                            if (qq == "")
                            {
                                CQ.SendGroupMessage(qlqh, String.Format("格式错误 请重新输入\n\n参考格式：\n动态惩罚后跟QQ/@QQ\n\n更多格式等你发现"));
                            }
                            else
                            {
                                if (jjyc != 2)
                                {
                                    var groupMember = CQ.GetGroupMemberInfo(qlqh, long.Parse(qq));
                                    string dat1 = groupMember.JoinTime.Date.ToString();
                                    if (dat1 == "1970/1/1 0:00:00")
                                    {
                                        CQ.SendGroupMessage(qlqh, String.Format("该QQ尚未加入本群 请核对后再试"));
                                        qlkg = 0;
                                        return;
                                    }
                                    QQQX(long.Parse(qq), qlqh);
                                    if (qqx == 1)
                                    {
                                        CQ.SendGroupMessage(qlqh, String.Format("对方是管理员或是群主哦~基基无法选中他做为目标"));
                                        qlkg = 0;
                                        return;
                                    }
                                }
                                long jysj = suiji.Next(1, 7);
                                CQ.SendGroupMessage(qlqh, String.Format("{0} 将被基基禁言 {1} 天 请小伙伴们引以为戒", CQ.CQCode_At(long.Parse(qq)), jysj));
                                CQ.SendPrivateMessage(long.Parse(qq), String.Format("你在 {0} 群被基基禁言 {1} 天 下不为例", qlqh, jysj));
                                jysj = jysj * 86400;
                                CQ.SetGroupMemberGag(qlqh, long.Parse(qq), jysj);
                            }
                        }
                        else
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("权限不足 无法使用"));
                        }
                        qlkg = 0;
                        return;
                    }
                    //找老婆
                    else if (msg == "召唤老婆" || msg.Contains("我老婆") || msg == "召唤老公" || msg.Contains("我老公")||msg.Contains("[CQ: image, file = E1613C44F5B2F8C2395278698FC3C468.jpg]") || msg.Contains("[CQ: image, file = 5BBC15FC94E5BC7F74FBEC16ED1DAABC.jpg]"))
                    {
                        int sf = SF(qlqq);
                        if (sf == 0)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("你还未注册小绿账号！\n快发句 签到\n基基将自动帮你注册账号{0}", CQ.CQCode_Face(178)));
                        }
                        else
                        {
                            QGZK(qlqq);
                            if (qgzk == "2")
                            {
                                CQ.SendGroupMessage(qlqh, String.Format("{0}", CQ.CQCode_At(cxdxqq)));
                            }
                            else
                            {
                                if (msg.Contains("老婆"))
                                {
                                    CQ.SendGroupMessage(qlqh, String.Format("单身狗哪有老婆"));
                                }
                                else
                                {
                                    CQ.SendGroupMessage(qlqh, String.Format("单身狗哪有老公"));
                                }
                            }
                        }
                        qgzk = "";
                        qlkg = 0;
                        return;
                    }
                    //结婚
                    else if (msg.Contains("我要结婚"))
                    {
                        int sf = SF(qlqq);
                        if (sf == 0)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("你还未注册小绿账号！\n快发句 签到\n基基将自动帮你注册账号{0}", CQ.CQCode_Face(178)));
                        }
                        else
                        {
                            string dxqq = System.Text.RegularExpressions.Regex.Replace(msg, @"[^0-9]+", "");
                            if (dxqq != "")
                            {
                                if (long.Parse(dxqq) == qlqq)
                                {
                                    CQ.SendGroupMessage(qlqh, String.Format("基基不跟自恋狂玩"));
                                }
                                else
                                {
                                    int jhnla = 15;
                                    if (jjyc != 2)
                                    {
                                        var jhnl = CQ.GetGroupMemberInfo(qlqh, qlqq);
                                        jhnla = jhnl.Age;
                                    }
                                    if (jhnla > 14)
                                    {
                                        long jhqq = long.Parse(dxqq);
                                        sf = SF(jhqq);
                                        if (sf == 0)
                                        {
                                            CQ.SendGroupMessage(qlqh, String.Format("该QQ尚未注册基基数据库哦~请核对后再试"));
                                        }
                                        else
                                        {
                                            QGZK(qlqq);
                                            if (qgzk == "2")
                                            {
                                                qgzk = "";
                                                CQ.SendGroupMessage(qlqh, String.Format("你已经是有家室的人了!"));
                                            }
                                            else
                                            {
                                                SQLiteCommand sjmz = new SQLiteCommand("select Green_user from kiki_user where QQ='" + qlqq + "'", QL);
                                                string sjmztm = sjmz.ExecuteScalar().ToString();
                                                if (sjmztm == "")
                                                {
                                                    CQ.SendGroupMessage(qlqh, String.Format("你还没有用户名哦~快私聊基基或直接在下面发送\n改名+你要修改的名字 首次修改免费 现已支持中文用户名"));
                                                    qlkg = 0;
                                                    return;
                                                }
                                                QGZK(jhqq);
                                                if (qgzk == "2")
                                                {
                                                    CQ.SendGroupMessage(qlqh, String.Format("ta已经结婚了哦~"));
                                                }
                                                else if (qgzk == "4")
                                                {
                                                    CQ.SendGroupMessage(qlqh, String.Format("ta拒绝被求婚哦~"));
                                                }
                                                else if (qgzk == "1" && cxdxqq == qlqq)
                                                {
                                                    CC(jhqq);
                                                    if (lb > 250)
                                                    {
                                                        int time = int.Parse(DateTime.Now.Month.ToString());
                                                        if (time == 6)
                                                        {
                                                            lb = lb - 125;
                                                        }
                                                        else
                                                        {
                                                            lb = lb - 250;
                                                        }
                                                        SQLiteCommand jhxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='" + jhqq + "',qgqk='2' where QQ='" + qlqq + "'", QL);
                                                        if (jhxg.ExecuteNonQuery() > 0)
                                                        {
                                                            CCXG(qlqq, 1, lb, 0, lz);
                                                            SQLiteCommand jhdxxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='" + qlqq + "',qgqk='2' where QQ='" + jhqq + "'", QL);
                                                            if (jhdxxg.ExecuteNonQuery() > 0)
                                                            {
                                                                CQ.SendGroupMessage(qlqh, String.Format("恭喜 {1}与{0} 喜♂结♀良♂缘♀~", CQ.CQCode_At(qlqq), CQ.CQCode_At(jhqq)));
                                                            }
                                                        }
                                                    }
                                                    else if (lz > 5)
                                                    {
                                                        int time = int.Parse(DateTime.Now.Month.ToString());
                                                        if (time == 6)
                                                        {
                                                            lz = lz - 3;
                                                        }
                                                        else
                                                        {
                                                            lz = lz - 5;
                                                        }
                                                        SQLiteCommand jhxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='" + jhqq + "',qgqk='2' where QQ='" + qlqq + "'", QL);
                                                        if (jhxg.ExecuteNonQuery() > 0)
                                                        {
                                                            CCXG(qlqq, 0, lb, 1, lz);
                                                            SQLiteCommand jhdxxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='" + qlqq + "',qgqk='2'  where QQ='" + jhqq + "'", QL);
                                                            if (jhdxxg.ExecuteNonQuery() > 0)
                                                            {
                                                                CQ.SendGroupMessage(qlqh, String.Format("恭喜 {1}与{0} 喜♂结♀良♂缘♀~", CQ.CQCode_At(qlqq), CQ.CQCode_At(jhqq)));
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        SQLiteCommand jhxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='0',qgqk='0' where QQ='" + qlqq + "'", QL);
                                                        if (jhxg.ExecuteNonQuery() > 0)
                                                        {
                                                            CQ.SendGroupMessage(qlqh, String.Format("结婚失败 你对象穷死了 结婚证都买不起"));
                                                        }
                                                    }
                                                }
                                                else if (msg.Contains("强制"))
                                                {
                                                    if (qlqq == admin1 || qlqq == admin2)
                                                    {
                                                        SQLiteCommand jhxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='" + jhqq + "',qgqk='2' where QQ='" + qlqq + "'", QL);
                                                        if (jhxg.ExecuteNonQuery() > 0)
                                                        {
                                                            SQLiteCommand jhdxxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='" + qlqq + "',qgqk='2' where QQ='" + jhqq + "'", QL);
                                                            if (jhdxxg.ExecuteNonQuery() > 0)
                                                            {
                                                                CQ.SendGroupMessage(qlqh, String.Format("恭喜最高管理员 {0}与{1} 喜♂结♀良♂缘♀~", CQ.CQCode_At(qlqq), CQ.CQCode_At(jhqq)));
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    CC(qlqq);
                                                    if (lb > 250 || lz > 5)
                                                    {
                                                        SQLiteCommand jhxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='" + jhqq + "',qgqk='1' where QQ='" + qlqq + "'", QL);
                                                        if (jhxg.ExecuteNonQuery() > 0)
                                                        {
                                                            CQ.SendPrivateMessage(jhqq, String.Format("QQ:{0} 想和你白头偕老{1}\n如果你也愿意那就在基基所在任意群发送\n我要结婚{2}\n如果不愿意请直接无视\n被骚扰的话请在下面直接回复 留言+内容 基基将告诉最高管理员", qlqq, CQ.CQCode_Face(179), qlqq));
                                                            CQ.SendGroupMessage(qlqh, String.Format("求婚请求已经发送给{0}了{1}", CQ.CQCode_At(jhqq), CQ.CQCode_Face(179)));
                                                        }
                                                    }
                                                    else
                                                    {
                                                        CQ.SendGroupMessage(qlqh, String.Format("没钱结什么婚"));
                                                    }
                                                }

                                            }
                                        }
                                    }
                                    else
                                    {
                                        CQ.SendGroupMessage(qlqh, String.Format("小孩子不要早恋！\n如果设置了个人资料仅自己或仅好友可见将无法获取实际资料，请修改后重新尝试。"));
                                    }
                                }
                            }
                            else
                            {
                                CQ.SendGroupMessage(qlqh, String.Format("请正确发送 我要结婚和你对象的QQ或直接@ta{0}\n不要复制假@ 请手动@ 不要偷懒！\n例如：我要结婚@帅比泷", CQ.CQCode_Face(179)));
                            }
                        }
                        qlkg = 0;
                        return;
                    }
                    else if (msg == "我要离婚")
                    {
                        int sf = SF(qlqq);
                        if (sf == 0)
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("你还未注册小绿账号！\n快发句 签到\n基基将自动帮你注册账号{0}", CQ.CQCode_Face(178)));
                        }
                        else
                        {
                            QGZK(qlqq);
                            if (qgzk == "2")
                            {
                                qgzk = "";
                                CC(qlqq);
                                if (lb > 250)
                                {
                                    lb = lb - 250;
                                    SQLiteCommand lhxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='0',qgqk='0' where QQ='" + cxdxqq + "'", QL);
                                    if (lhxg.ExecuteNonQuery() > 0)
                                    {
                                        CCXG(qlqq, 1, lb, 0, lz);
                                        SQLiteCommand lhdxxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='0',qgqk='0' where QQ='" + qlqq + "'", QL);
                                        if (lhdxxg.ExecuteNonQuery() > 0)
                                        {
                                            CQ.SendPrivateMessage(cxdxqq, String.Format("你的ta抛弃了你"));
                                            CQ.SendGroupMessage(qlqh, String.Format("{0}与{1} 感情破裂 缘分已尽", CQ.CQCode_At(qlqq), CQ.CQCode_At(cxdxqq)));
                                        }
                                    }
                                }
                                else if (lz > 5)
                                {
                                    lz = lz - 5;
                                    SQLiteCommand lhxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='0',qgqk='0' where QQ='" + cxdxqq + "'", QL);
                                    if (lhxg.ExecuteNonQuery() > 0)
                                    {
                                        CCXG(qlqq, 0, lb, 1, lz);
                                        SQLiteCommand lhdxxg = new SQLiteCommand("UPDATE kiki_user set dxQQ='0',qgqk='0' where QQ='" + qlqq + "'", QL);
                                        if (lhdxxg.ExecuteNonQuery() > 0)
                                        {
                                            CQ.SendPrivateMessage(cxdxqq, String.Format("你的ta抛弃了你"));
                                            CQ.SendGroupMessage(qlqh, String.Format("{0}与{1} 感情破裂 缘分已尽", CQ.CQCode_At(qlqq), CQ.CQCode_At(cxdxqq)));
                                        }
                                    }
                                }
                                else
                                {
                                    CQ.SendGroupMessage(qlqh, String.Format("没钱离什么婚"));
                                }
                            }
                            else
                            {
                                CQ.SendGroupMessage(qlqh, String.Format("你个单身狗离什么婚"));
                            }
                        }
                        qlkg = 0;
                        return;
                    }
                    else if (msg.Contains("投票惩罚") && LLLM.Contains(qlqh) && jjyc != 2)
                    {
                        if (jjyc != 2)
                        {
                            var groupMember = CQ.GetGroupMemberInfo(490392598, qlqq);
                            DateTime dat1 = groupMember.JoinTime.Date;
                            DateTime dat3 = DateTime.Now.Date;
                            TimeSpan ts1 = dat3 - dat1;
                            rqday = ts1.Days;
                        }
                        if (rqday <= 1 || XJQCY.Contains(qlqq))
                        {
                            CQ.SendGroupMessage(490392598, String.Format("为了防止刷票 新入群的同学无法使用本功能 谢谢合作", qlqq));
                        }
                        int sf = SF(qlqq);
                        if (sf == 1)
                        {
                            string qq;
                            qq = System.Text.RegularExpressions.Regex.Replace(msg, @"[^0-9]+", "");
                            if (qq == "")
                            {
                                CQ.SendGroupMessage(qlqh, String.Format("格式错误 请重新输入\n\n参考格式：\n投票惩罚后跟QQ/@QQ\n\n例如：投票惩罚@最丑的小白兔"));
                            }
                            else
                            {
                                var groupMember = CQ.GetGroupMemberInfo(qlqh, long.Parse(qq));
                                string dat1 = groupMember.JoinTime.Date.ToString();
                                if (dat1 == "1970/1/1 0:00:00")
                                {
                                    CQ.SendGroupMessage(qlqh, String.Format("该QQ尚未加入本群 请核对后再试"));
                                }
                                else
                                {
                                    if (long.Parse(qq) == dlqq)
                                    {
                                        CQ.SetGroupMemberGag(qlqh, qlqq, 600);
                                        qlkg = 0;
                                        return;
                                    }
                                    KKQX(qlqq);
                                    if (kkqx < 5)
                                    {
                                        SQLiteCommand tpcff = new SQLiteCommand("select count(*) from 投票日志 where QQ='" + qlqq + "' and QH='" + qlqh + "' and TIME='" + jtjh + "'", QL);
                                        if (int.Parse(tpcff.ExecuteScalar().ToString()) > 0)
                                        {
                                            CQ.SendGroupMessage(qlqh, String.Format("你今天在本群已经参与过投票惩罚了哦qaq"));
                                            qlkg = 0;
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        SQLiteCommand tpcff = new SQLiteCommand("select count(*) from 投票日志 where QQ='" + qlqq + "' and QH='" + qlqh + "' and DXQQ='" + qq + "'", QL);
                                        if (int.Parse(tpcff.ExecuteScalar().ToString()) > 0)
                                        {
                                            CQ.SendGroupMessage(qlqh, String.Format("你今天在本群已经参与过关于他的投票惩罚了哦qaq"));
                                            qlkg = 0;
                                            return;
                                        }
                                    }
                                    QQQX(long.Parse(qq), qlqh);
                                    if (qqx == 1)
                                    {
                                        CQ.SendGroupMessage(qlqh, String.Format("对方是管理员或是群主哦~基基无法选中他做为目标"));
                                        qlkg = 0;
                                        return;
                                    }
                                    dqsj = DateTime.Parse(DateTime.Now.ToShortTimeString());
                                    var b = dqsj.AddMinutes(15);

                                    int ps = 0;
                                    SQLiteCommand tpcx = new SQLiteCommand("select * from 绿绿联盟列表 where qh='" + qlqh + "'", QL);
                                    SQLiteDataReader tpcf2 = tpcx.ExecuteReader();
                                    if (tpcf2.Read())
                                    {

                                        if (kkqx == 0 || kkqx == 1)
                                        {
                                            ps = 1;
                                        }
                                        else if (kkqx == 2)
                                        {
                                            ps = 2;
                                        }
                                        else if (kkqx == 5 || kkqx == 6 || kkqx == 10)
                                        {
                                            ps = 5;
                                        }
                                        if (tpcf2[5].ToString() == "0")
                                        {
                                            SQLiteCommand tpcf3 = new SQLiteCommand("UPDATE 绿绿联盟列表 set jydxqq='" + qq + "',zt='1' where qh='" + qlqh + "'", QL);
                                            tpcf3.ExecuteNonQuery();
                                            CQ.SendGroupMessage(qlqh, String.Format("请勿滥用本功能 你的本次操作已经被记录！"));
                                        }
                                        if (tpcf2[2].ToString() != qq && tpcf2[5].ToString() == "1")
                                        {
                                            CQ.SendGroupMessage(qlqh, String.Format("本群当前正在进行投票表决 请稍后再试QWQ"));
                                        }
                                        else
                                        {
                                            if (int.Parse(tpcf2[3].ToString()) > 5)
                                            {
                                                if (kkqx == 5 || kkqx == 6)
                                                {
                                                    ps = 3;
                                                }
                                            }
                                            else if (int.Parse(tpcf2[3].ToString()) > 10 && kkqx == 10)
                                            {
                                                ps = 3;
                                            }
                                            ps = int.Parse(tpcf2[3].ToString()) + ps;
                                            if (ps >= 20)
                                            {
                                                SQLiteCommand tpcf3 = new SQLiteCommand("UPDATE 绿绿联盟列表 set time='0',zt='0',ps='0',time='0' where qh='" + qlqh + "'", QL);
                                                if (tpcf3.ExecuteNonQuery() > 0)
                                                {
                                                    CQ.SendGroupMessage(qlqh, String.Format("{0} 已经被基基踢走惹QWQ", CQ.CQCode_At(long.Parse(qq))));
                                                    CQ.SetGroupMemberRemove(qlqh, long.Parse(qq));
                                                }
                                            }
                                            else
                                            {
                                                long time = 0;
                                                if (ps >= 18)
                                                {
                                                    time = 2592000;
                                                }
                                                else if (ps >= 15)
                                                {
                                                    time = 1296000;
                                                }
                                                else if (ps >= 10)
                                                {
                                                    time = 604800;
                                                }
                                                else if (ps >= 7)
                                                {
                                                    time = 259200;
                                                }
                                                else if (ps == 5)
                                                {
                                                    time = 86400;
                                                }
                                                else if (ps == 3)
                                                {
                                                    time = 43200;
                                                }
                                                else if (ps == 2)
                                                {
                                                    time = 3600;
                                                }
                                                if (ps == 1)
                                                {
                                                    time = 600;
                                                }
                                                SQLiteCommand tpcf3 = new SQLiteCommand("UPDATE 绿绿联盟列表 set time='" + b + "',ps='" + ps + "' where qh='" + qlqh + "'", QL);
                                                if (tpcf3.ExecuteNonQuery() > 0)
                                                {
                                                    if (time > 0)
                                                    {
                                                        CQ.SendGroupMessage(qlqh, String.Format("【投票惩罚】\n{3} 投票成功！\n当前票数：{1}\n{0} 已经被基基禁言{2}秒了qwq", CQ.CQCode_At(long.Parse(qq)), ps, time, CQ.CQCode_At(qlqq)));
                                                        CQ.SetGroupMemberGag(qlqh, long.Parse(qq), time);
                                                    }
                                                    else
                                                    {
                                                        CQ.SendGroupMessage(qlqh, String.Format("【投票惩罚】\n{0} 投票成功！\n当前票数：{1}", CQ.CQCode_At(qlqq), ps));
                                                    }
                                                    SQLiteCommand tpcf4 = new SQLiteCommand("INSERT into 投票日志 (id,QQ,QH,TIME,DXQQ)VALUES(null,'" + qlqq + "','" + qlqh + "','" + jtjh + "','" + qq + "')", QL);
                                                    tpcf4.ExecuteNonQuery();
                                                    tpdskg = 1;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("你还不是小绿用户噢~无法使用本功能qwq"));
                        }
                        qlkg = 0;
                        return;
                    }
                    qlkg = 0;
                }
                //探测器
                else if (kg == 0 && qdtx != qlqq && zczh != qlqq && LLLM.Contains(qlqh) && !TCQ.Contains(qlqq))
                {
                    TCQ.Add(qlqq);
                    int sf = SF(qlqq);
                    if (sf == 0)
                    {
                        if (qlqh == 490392598)
                        {
                            zczh = qlqq;
                            CQ.SendGroupMessage(qlqh, String.Format("{1}\n基基发现你还未注册小绿账号！\n快发句 签到\n基基将自动帮你注册账号{0}{2}", CQ.CQCode_Face(178), CQ.CQCode_At(zczh), qdtxgg));
                        }
                    }
                    else
                    {
                        if (sz > 5 || xq == "Sunday" || xq == "Saturday")
                        {
                            qdtx = qlqq;
                            KKQX(qdtx);
                            if (kkqx >= 1)
                            {
                                SQLiteCommand sfqd = new SQLiteCommand("select count(*) from 签到日志 where QQ='" + qdtx + "' and Time='" + jtjh + "'", QL);
                                long ymyqd = long.Parse(sfqd.ExecuteScalar().ToString());
                                if (ymyqd == 0)
                                {
                                    if (qdtx == admin1 || qdtx == admin2)
                                    {
                                        CQ.SendGroupMessage(qlqh, String.Format("尊敬的最高管理员 您今日尚未签到 基基将自动为您运行签到系统"));
                                        Login(qdtx, qlqh);
                                        kkqx = 0;
                                        qlkg = 0;
                                    }
                                    else
                                    {
                                        CQ.SendGroupMessage(qlqh, String.Format("{1}\n基基提醒你记得签到{0}{2}", CQ.CQCode_Face(178), CQ.CQCode_At(qdtx), qdtxgg));
                                    }
                                }
                            }
                        }
                        xgyhm = qlqq;
                        SQLiteCommand xlyh = new SQLiteCommand("select Green_user from kiki_user where QQ='" + fromQQ + "'", QL);
                        if (xlyh.ExecuteScalar().ToString() == "")
                        {
                            CQ.SendGroupMessage(qlqh, String.Format("{0}\n基基宝宝提醒你 记得修改用户名qwq", CQ.CQCode_At(xgyhm)));
                        }
                    }
                    //if (jjyc != 2)
                    //{
                    //    var groupMember = CQ.GetGroupMemberInfo(qlqh, qlqq);
                    //    string sex = groupMember.Gender;
                    //    if (sex.Contains("女"))
                    //    {
                    //        SQLiteCommand mzsjk = new SQLiteCommand("select count(*) from 妹纸 where QQ='" + qlqq + "'", QL);
                    //        if (int.Parse(mzsjk.ExecuteScalar().ToString()) == 0)
                    //        {
                    //            int age = groupMember.Age;
                    //            string name = CQE.GetQQName(qlqq);
                    //            sj = jtjh + sz + "时" + fz + "分" + mz + "秒";
                    //            SQLiteCommand mztj = new SQLiteCommand("INSERT into 妹纸(id,QQ,QH,Time) VALUES(null,'" + qlqq + "','" + qlqh + "','" + sj + "')", QL);
                    //            if (mztj.ExecuteNonQuery() > 0)
                    //            {
                    //                CQ.SendPrivateMessage(admin1, String.Format("基基在QQ群：{0}\n发现一个{2}岁的妹纸：{3}\n她的QQ：{1}", qlqh, qlqq, age, name));
                    //                CQ.SendPrivateMessage(admin2, String.Format("基基在QQ群：{0}\n发现一个{2}岁的妹纸：{3}\n她的QQ：{1}", qlqh, qlqq, age, name));
                    //            }
                    //        }
                    //    }
                    //}
                    qlkg = 0;
                    return;
                }
                #endregion
            }
        }     
        /// <summary>
        /// Type=103 群事件-群成员增加。
        /// </summary>
        /// <param name="subType">子类型，1/管理员已同意 2/管理员邀请。</param>
        /// <param name="sendTime">发送时间(时间戳)。</param>
        /// <param name="fromGroup">来源群。</param>
        /// <param name="fromQQ">来源QQ。</param>
        /// <param name="beingOperateQQ">被操作QQ。</param>
        public override void GroupMemberIncrease(int subType, int sendTime, long fromGroup, long fromQQ, long beingOperateQQ)
        {
            if (beingOperateQQ < 0)
            {
                beingOperateQQ = beingOperateQQ + 4294967296;
                if (beingOperateQQ < 0)
                {
                    return;
                }
            }
            if (beingOperateQQ == dlqq)
            {
                CQ.SendGroupMessage(fromGroup, String.Format("基基宝宝来惹 有没有小可爱欢迎我QAQ"));
            }
            else
            {
                if (LLLM.Contains(fromGroup))
                {
                    if (fromGroup == 490392598)
                    {
                        XJQCY.Add(beingOperateQQ);
                        CQ.SetGroupMemberGag(fromGroup, beingOperateQQ, 300);
                        CQ.SendPrivateMessage(beingOperateQQ, String.Format("欢迎来到小绿科技官方交流群{0}\n我是最可爱的机器人 基基QWQ\n小绿辅助-魔法哈奇已经恢复运营 充值赞助问题请联系群主\n对基基有建议或意见记得对我说 留言和你要说的话\n祝你在小绿群找到属于自己的友情哦~\nPS：为了防止广告你将会被禁言一段时间 请耐心等待时间结束", CQ.CQCode_Face(178)));
                    }
                }
                CQ.SendGroupMessage(fromGroup, String.Format("欢迎新人 {0}", CQ.CQCode_At(beingOperateQQ)));
                CQ.SendGroupMessage(fromGroup, String.Format("新人快点眼熟我{0}{1}", CQ.CQCode_Face(178), rqgg));
            }
        }
        /// <summary>
        /// Type=302 请求-群添加。
        /// </summary>
        /// <param name="subType">子类型，目前固定为1。</param>
        /// <param name="sendTime">发送时间(时间戳)。</param>
        /// <param name="fromGroup">来源群号。</param>
        /// <param name="fromQQ">来源QQ。</param>
        /// <param name="msg">附言。</param> 
        /// <param name="responseFlag">反馈标识(处理请求用)。</param>
        public override void RequestAddGroup(int subType, int sendTime, long fromGroup, long fromQQ, string msg, string responseFlag)
        {
            // 处理请求-群添加。
            if (fromQQ == admin1 || fromQQ == admin2)
            {
                CQ.SetGroupAddRequest("基基正在申请加群", CQRequestType.GroupInvite, CQReactType.Allow, "最萌的基基小可爱来惹QWQ");
            }
        }
        /// <summary>
        /// Type=4 讨论组消息。
        /// </summary>
        /// <param name="subType">子类型，目前固定为1。</param>
        /// <param name="sendTime">发送时间(时间戳)。</param>
        /// <param name="fromDiscuss">来源讨论组。</param>
        /// <param name="fromQQ">来源QQ。</param>
        /// <param name="msg">消息内容。</param>
        /// <param name="font">字体。</param>
        public override void DiscussMessage(int subType, int sendTime, long fromDiscuss, long fromQQ, string msg, int font)
        {
            // 处理讨论组消息。
            CQ.SetDiscussExit(fromDiscuss);
        }
        /// <summary>
        /// Type=102 群事件-群成员减少。
        /// </summary>
        /// <param name="subType">子类型，1/群员离开 2/群员被踢 3/自己(即登录号)被踢。</param>
        /// <param name="sendTime">发送时间(时间戳)。</param>
        /// <param name="fromGroup">来源群。</param>
        /// <param name="fromQQ">来源QQ。</param>
        /// <param name="beingOperateQQ">被操作QQ。</param>
        public override void GroupMemberDecrease(int subType, int sendTime, long fromGroup, long fromQQ, long beingOperateQQ)
        {
            // 处理群事件-群成员减少。
            if (beingOperateQQ == admin1 || beingOperateQQ == admin2 || beingOperateQQ == dlqq)
            {
                CQ.SetGroupExit(fromGroup, false);
                SQLiteCommand lllm = new SQLiteCommand("select count(*) from 绿绿联盟列表 where qh='" + fromGroup + "'", QT);
                int lllmcz = int.Parse(lllm.ExecuteScalar().ToString());
                if (lllmcz > 0)
                {
                    SQLiteCommand ldid = new SQLiteCommand("select id from 绿绿联盟列表 where qh='" + fromGroup + "'", QT);
                    int ldidd = int.Parse(ldid.ExecuteScalar().ToString());
                    SQLiteCommand tjid = new SQLiteCommand("UPDATE 绿绿联盟列表 set qh='0' where id='" + ldidd + "'", QT);
                    if (tjid.ExecuteNonQuery() > 0)
                    {
                        CQ.SendPrivateMessage(admin1, String.Format("{0}群已自动退出绿绿联盟", fromGroup));
                    }
                }
            }
            else if (fromGroup == 490392598)
            {
                if (jjyc != 2)
                {
                    var groupMember = CQ.GetGroupMemberInfo(490392598, beingOperateQQ);
                    DateTime dat1 = groupMember.JoinTime.Date;
                    DateTime dat3 = DateTime.Now.Date;
                    TimeSpan ts1 = dat3 - dat1;
                    rqday = ts1.Days;
                }
                if (rqday <= 1||XJQCY.Contains(beingOperateQQ))
                {
                    CQ.SendGroupMessage(490392598, String.Format("！ban {0} 影响管理休息", beingOperateQQ));
                }
            }
        }
    }
}
